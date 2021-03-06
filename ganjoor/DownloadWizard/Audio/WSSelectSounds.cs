﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ganjoor
{
    public partial class WSSelectSounds : WizardStage
    {
        public WSSelectSounds() : this(0)
        {
        }

        public WSSelectSounds(int nPoemId)
        {
            InitializeComponent();
            _PoemId = nPoemId;            
        }

        //شناسه شعر
        //۰ یعنی کلیه شعرها
        private int _PoemId
        {
            set;
            get;
        }

        //نشانی لیست خوانشها
        private string ListUrl
        {
            get
            {
                return "http://a.ganjoor.net/?p=" + _PoemId.ToString();
            }
        }


        public override void OnActivated()
        {
            TryDownloadList();
        }

        //دریافت فهرست
        private void TryDownloadList()
        {
            btnRefresh.Visible = false;
            tlbr.Enabled = false;
            lblDesc.BackColor = System.Drawing.SystemColors.Window;
            lblDesc.Text = "در حال دریافت اطلاعات ...";
            Application.DoEvents();
            if (RetrieveList())
            {
                lblDesc.Text = "ردیفهای سفیدرنگ نشانگر خوانشهایی است که شما آنها را در گنجور رومیزی خود ندارید. با علامتگذاری ستون «دریافت» در هر ردیف؛ آن را به فهرست خوانشهایی که می‌خواهید دریافت شوند اضافه کنید تا در مرحلهٔ بعد دریافت فهرست انتخابی شروع شود.";
                if (grdList.RowCount == 0)
                {
                    lblDesc.Text = "خوانشی برای این شعر یافت نشد.";
                    lblDesc.BackColor = Color.Red;
                }
            }
            else
            {
                lblDesc.BackColor = Color.Red;
                btnRefresh.Visible = true;
                lblDesc.Text = "دریافت یا پردازش فهرست خوانشها با خطا مواجه شد. لطفاً از اتصال ارتباط اینترنتیتان اطمینان حاصل کنید و دکمهٔ تلاش مجدد را بزنید.";
            }
            tlbr.Enabled = true;
        }

        private const int GRDCLMN_TITLE = 0;
        private const int GRDCLMN_SIZE = 1;
        private const int GRDCLMN_CHECK = 2;


        private List<Dictionary<string, string>> _Lst = new List<Dictionary<string, string>>();

        //دریافت فهرست
        private bool RetrieveList()
        {
            bool reS = true;
            grdList.Rows.Clear();
            string strException;
            _Lst = DownloadableAudioListProcessor.RetrieveList(ListUrl, out strException);
            if (!string.IsNullOrEmpty(strException))
            {
                MessageBox.Show(strException, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reS = false;
            }
            else
            {
                DbBrowser db = new DbBrowser();
                foreach (Dictionary<string, string> audioInfo in _Lst)
                {
                    int RowIndex = grdList.Rows.Add();
                    int nPoemId = Convert.ToInt32(audioInfo["audio_post_ID"]);

                    bool haveIt = db.PoemAudioExists(nPoemId, audioInfo["audio_guid"]);
                    grdList.Rows[RowIndex].Tag = haveIt;
                    if (haveIt)
                        grdList.Rows[RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    grdList.Rows[RowIndex].Cells[GRDCLMN_TITLE].Value = DownloadableAudioListProcessor.SuggestTitle(audioInfo);
                    grdList.Rows[RowIndex].Cells[GRDCLMN_SIZE].Value = (Int32.Parse(audioInfo["audio_mp3bsize"]) / 1024.0 / 1024.0).ToString("0.00") + " مگابایت";
                    grdList.Rows[RowIndex].Cells[GRDCLMN_CHECK].Value = !haveIt;
                    if (!haveIt)
                    {
                        grdList.FirstDisplayedScrollingRowIndex = RowIndex;
                    }
                }
                db.CloseDb();
                EnableDownloadCheckedButton();
            }

            return reS;
        }




        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case GRDCLMN_CHECK:
                    grdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !Convert.ToBoolean(grdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    break;
            }
        }

        private void grdList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GRDCLMN_CHECK)
                EnableDownloadCheckedButton();
        }

        private void EnableDownloadCheckedButton()
        {
            foreach (DataGridViewRow Row in grdList.Rows)
                if (Convert.ToBoolean(Row.Cells[GRDCLMN_CHECK].Value))
                {
                    if (OnEnableNextButton != null)
                        OnEnableNextButton(this, new EventArgs());
                    return;

                }
            if (OnDisableNextButton != null)
                OnDisableNextButton(this, new EventArgs());
        }


        public List<Dictionary<string, string>> dwnldList
        {
            get;
            set;
        }

        public override void OnApplied()
        {
            dwnldList = new List<Dictionary<string, string>>();
            foreach (DataGridViewRow Row in grdList.Rows)
                if (Convert.ToBoolean(Row.Cells[GRDCLMN_CHECK].Value))
                    dwnldList.Add(_Lst[Row.Index]);
        }

        public event EventHandler OnEnableNextButton = null;
        public event EventHandler OnDisableNextButton = null;

        private void btnSelNone_Click(object sender, EventArgs e)
        {
            if (grdList.IsCurrentCellInEditMode)
                grdList.EndEdit();
            foreach (DataGridViewRow Row in grdList.Rows)
                Row.Cells[GRDCLMN_CHECK].Value = false;

        }

        private void btnSelAllWhites_Click(object sender, EventArgs e)
        {
            if (grdList.IsCurrentCellInEditMode)
                grdList.EndEdit();
            foreach (DataGridViewRow Row in grdList.Rows)
                if (!((bool)Row.Tag))
                    Row.Cells[GRDCLMN_CHECK].Value = true;
        }

        //تلاش مجدد
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TryDownloadList();
        }

        private void btnAllDownloadable_Click(object sender, EventArgs e)
        {
            _PoemId = 0;
            TryDownloadList();
        }


    }
}
