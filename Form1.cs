namespace CatchButton
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void target_MouseEnter(object sender, EventArgs e)
        {
            //난수 생성 준비
            Random rd = new Random();

            //가용 영역 계산(버튼이 창 밖으로 나가거나 창에 걸리지 않게 보호)
            //클라이언트사이즈는 창의 타이틀바하고 테두리 제외한 영역.
            int MaxX = this.ClientSize.Width;
            int MaxY = this.ClientSize.Height;

            int nextX = rd.Next(0, MaxX);
            int nextY = rd.Next(0, MaxY);

            //위치 할당 새로운 포인트 객체 생성
            target.Location = new Point(nextX, nextY);

            //시각적 피드백, 움직이는 버튼의 좌표를 출력함.
            this.Text = $"버튼 위치: ({nextX}, {nextY})";
        }

        private void target_Click(object sender, EventArgs e)
        {

        }

        private void target_LocationChanged(object sender, EventArgs e)
        {
            int x_position = 100;
            int y_position = 150;

            target.Location = new Point(x_position, y_position);
        }
    }
}
