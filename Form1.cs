using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace CatchButton
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        int score = 100;

        void RestartGame()
        {
            score = 500;
            this.Text = "🎯 버튼 잡기 게임 | 점수 : " + score;

            target.Width = 100;
            target.Height = 40;

            int MaxX = this.ClientSize.Width - target.Width;
            int MaxY = this.ClientSize.Height - target.Height;

            Random rd = new Random();
            target.Location = new Point(rd.Next(0, MaxX), rd.Next(0, MaxY));
        }

        public Form1()
        {
            InitializeComponent();
            this.Text = "점수:" + score;
            this.Text = "🎯 버튼 잡기 게임 | 점수 : " + score;

        }

        private void target_MouseEnter(object sender, EventArgs e)
        {
            //난수 생성 준비
            Random rd = new Random();

            //가용 영역 계산(버튼이 창 밖으로 나가거나 창에 걸리지 않게 보호)
            //클라이언트사이즈는 창의 타이틀바하고 테두리 제외한 영역.
            int MaxX = this.ClientSize.Width - target.Width;
            int MaxY = this.ClientSize.Height - target.Height;

            int nextX = rd.Next(0, MaxX);
            int nextY = rd.Next(0, MaxY);

            //위치 할당 새로운 포인트 객체 생성
            target.Location = new Point(nextX, nextY);

            //시각적 피드백, 움직이는 버튼의 좌표를 출력함.
            this.Text = $"버튼 위치: ({nextX}, {nextY})";

            score -= 10;
            this.Text = "🎯 버튼 잡기 게임 | 점수 : " + score;

            if (score <= 0)
            {
                DialogResult result = MessageBox.Show(
                    "못 잡았다... 게임 종료..",
                    "다시 도전 할까요?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    RestartGame();
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }

            }
        }

        private void target_Click(object sender, EventArgs e)
        {

        }

        private void target_LocationChanged(object sender, EventArgs e)
        {

        }

        private void target_MouseDown(object sender, MouseEventArgs e)
        {

            target.Width = (int)(target.Width * 0.9);
            target.Height = (int)(target.Height * 0.9);

            this.Text = $"축하합니다!";

            score += 100;
            this.Text = "🎯 버튼 잡기 게임 | 점수 : " + score;


            if (score >= 1000)
            { 
                MessageBox.Show(
                    "축하합니다! 게임에서 승리 하셨습니다!", 
                    "성공",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                 );
                System.Windows.Forms.Application.Exit();
            }



        }
    }
}
