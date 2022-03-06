using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Master_of_PDF
{
    public partial class Form1 : Form
    {
        //Form画面を隠してもマウスドラッグで画面移動を可能するための準備 //
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(

        IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        //--------------------------------------------------------------//

        private Form activeFom = null;

        public Form1()
        {
            InitializeComponent();
            CostomizeDesing();
            this.Text = "Doshboard of PDF";
            panelTitleBar.MouseDown += new MouseEventHandler(this.Form1_MouseDown);
        }


        /// <summary>
        /// サブメニューパネルを隠す
        /// </summary>
        private void CostomizeDesing()
        {
            panelMargeSubMenu.Visible = false;
            panelSplitSubMenu.Visible = false;
        }

        /// <summary>
        /// 表示されているメニュー画面を閉じる
        /// </summary>
        private void HideSubMenu()
        {
            if (panelMargeSubMenu.Visible == true)
            {
                panelMargeSubMenu.Visible = false;
            }
            if (panelSplitSubMenu.Visible == true)
            {
                panelSplitSubMenu.Visible = false;
            }
        }

        /// <summary>
        /// 指定のパネルを開き、他のパネルは閉じる
        /// </summary>
        /// <param name="sub_menu">開きたいパネル</param>
        private void ShowSubMenu(Panel sub_menu)
        {
            if (sub_menu.Visible == false)
            {
                HideSubMenu();
                sub_menu.Visible = true;
            }
            else
            {
                sub_menu.Visible = false;
            }

        }

        /// <summary>
        /// ページ結合ボタンを押した時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarge_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMargeSubMenu);
        }

        /// <summary>
        /// ページ分割/ページ抽出ボタンを押した時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSplitAandExtraction_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSplitSubMenu);
        }

        private void openChildForm(Form childForm)
        {

            if (activeFom != null)
            {
                activeFom.Close();
            }

            activeFom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        //Form1のMouseDownイベントハンドラ
        //マウスのボタンが押されたとき
        private void Form1_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //マウスのキャプチャを解除
                ReleaseCapture();
                //タイトルバーでマウスの左ボタンが押されたことにする
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        private void btnMargeSubMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //HideSubMenu();
        }

        private void btnSplitSubMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //HideSubMenu()
        }

        private void btnExtractionSubMenu_Click(object sender, EventArgs e)
        {

        }

        
    }
}
