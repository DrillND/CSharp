using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace carFixMgr0611.common
{
    class CommUtil
    {
        public static void initTheme(Form form)
        {
            var mgr = MaterialSkinManager.Instance;
            mgr.AddFormToManage(form as MaterialForm);
            mgr.Theme =
                MaterialSkinManager.Themes.LIGHT;
            mgr.ColorScheme =
                new ColorScheme(
                    Primary.Indigo700,
                    Primary.Indigo700,
                    Primary.Indigo700,
                    Accent.Indigo700,
                    TextShade.WHITE);
        }

        //그리드 뷰 줄 색상
        public static void setRowColor(ListView list, Color even, Color odd)
        //재활용성 높은 코드 따로 빼놔도 된다.
        //static있으면 클래스 매소드,변수(객체생성 안해도 된다.)
        //없으면 인스턴스 매소드
        {
            foreach (ListViewItem item in list.Items)
            {
                if (item.Index % 2 == 0)
                {
                    item.BackColor = even;
                }
                else
                {
                    item.BackColor = odd;
                }
            }
        }

        //그리드 뷰 열 제목 색상
        public static void colorListViewHeader(ref ListView list, Color backColor, Color foreColor) //ref 주소값 전달, out
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader +=
                new DrawListViewColumnHeaderEventHandler
                (
                    (sender, e) => headerDraw(sender, e, backColor, foreColor)
                    //(sender, e) => 람다식, 객체지향과는 조금 다른 개념, 안 배움.
                 );
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
        }

        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            using(SolidBrush backBrush = new SolidBrush(backColor))
                //using 자원 반납 안해도 된다. close()같은거 안해도 됨.
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using(SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }

        }
        private static void bodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
