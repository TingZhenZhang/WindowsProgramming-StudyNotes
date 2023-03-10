using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RandomButtonDemo
{
    public partial class Form1 : Form
    {
        //今天上課會用到的List陣列
        //List<int> cardList = new List<int>();
        List<PokerModel> cardList = new List<PokerModel>();
        List<Button> buttonList = new List<Button>();

        PokerModel currentSelectedPoker;
        Boolean isWaiting;

        int matchCount = 0;
        int spendtime = 0;

        //建構式，任何Class都會從建構式先開始執行
        public Form1()
        {
            InitializeComponent();
            //將建立很多很多按鈕的方法在這邊呼叫，就會在"Form1被載入的時候"執行
            //initButtonList();

            //initArray();
            //suffleArray();

            initCard();
            suffleCard();
            initButtonList();
        }

        //建立很多很多按鈕
        void initButtonList()
        {
            int index = 0;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 13; x++)
                {
                    addButton(x, y, cardList[index]);
                    index++;
                }
            }
        }

        //根據x、y、index來在畫面上加入按鈕
        //其中x、y為我們自定義的橫列或直列的第幾個，而非實際上畫面上的像素位置
        //index則為該按鈕的索引編號
        //void addButton(int x, int y, int index)
        //{
        //    int buttonWidth = 35;
        //    int buttonHeight = 35;

        //    int buttonSpace = 5;

        //    int buttonX = buttonSpace + x * (buttonWidth + buttonSpace);
        //    int buttonY = buttonSpace + y * (buttonHeight + buttonSpace);

        //    Button button = new Button();
        //    button.Location = new Point(buttonX, buttonY);
        //    button.Size = new Size(buttonWidth, buttonHeight);
        //    button.Text = index.ToString();
        //    button.Tag = index;
        //    button.Click += new EventHandler(this.Button_Click);

        //    this.Controls.Add(button);
        //}

        void addButton(int x, int y, PokerModel poker)
        {
            int buttonWidth = 52;
            int buttonHeight = 75;
            int buttonSpace = 5;
            int buttonX = buttonSpace + x * (buttonWidth + buttonSpace);
            int buttonY = buttonSpace + y * (buttonHeight + buttonSpace);
            Button button = new Button();
            button.Location = new Point(buttonX, buttonY);
            button.Size = new Size(buttonWidth, buttonHeight);
            //button.Text = poker.suit + "_" + poker.face;//花色_牌面
            button.Tag = poker;
            button.Click += new EventHandler(this.Button_Click);

            updateButtonImage(button);//更新圖片

            this.cardPanel.Controls.Add(button);//在cardPanel裡新增牌
            buttonList.Add(button);
        }

        //按鈕的點擊事件
        private void Button_Click(object sender, EventArgs e)
        {
            spendTimer.Start();
            if (isWaiting == true)
            {
                return;//等待中 不可翻牌
            }

            Button button = (Button)sender;
            PokerModel poker = (PokerModel)button.Tag;
            //Console.WriteLine(button.Tag);

            if (!poker.isBack)
            {
                return;//若牌為正面 不翻回背面 不執行下面程式碼
            }

            poker.isBack = false;
            updateButtonImage(button);

            if (currentSelectedPoker != null)
            {
                if (currentSelectedPoker.face == poker.face)
                {
                    currentSelectedPoker.isHide = true;
                    poker.isHide = true;
                    matchCount++;
                }
                else
                {
                    currentSelectedPoker.isBack = true;
                    poker.isBack = true;
                }
            }

            if (currentSelectedPoker != null)//第二次翻的
            {
                currentSelectedPoker.isBack = true;
                poker.isBack = true;
                currentSelectedPoker = null;

                //Application.DoEvents();
                //Thread.Sleep(100);//會造成程式卡住 BAD方法

                //updateAllButtonImage();
                cardTimer.Start();
                isWaiting = true;
            }
            else//第一次翻的
            {
                currentSelectedPoker = poker;
            }

            //poker.isBack = !poker.isBack;//點擊後翻牌
            //updateButtonImage(button);
        }

        Image getImageByPoker(PokerModel poker)
        {
            if (poker.isBack)
            {
                return Properties.Resources.Card_000;
            }
            string name = "Card_" + poker.pokerValue();
            return (Image)Properties.Resources.ResourceManager.GetObject(name);
        }

        //void suffleArray()
        //{
        //    Random random = new Random();
        //    int count = 0;
        //    for (int i = 0; i < cardList.Count; i++)
        //    {
        //        count++;
        //        int randomNumber = random.Next(0, cardList.Count);
        //        int temp = cardList[i];
        //        cardList[i] = cardList[randomNumber];
        //        cardList[randomNumber] = temp;
        //    }
        //}

        void suffleCard()
        {
            Random random = new Random();
            //int count = 0;
            for (int i = 0; i < cardList.Count; i++)
            {
                //count++;
                int randomNumber = random.Next(0, cardList.Count);
                PokerModel temp = cardList[i];
                cardList[i] = cardList[randomNumber];
                cardList[randomNumber] = temp;
            }
        }

        //void initArray()
        //{
        //    for (int i = 1; i <= 64; i++)
        //    {
        //        cardList.Add(i);
        //    }
        //}

        void initCard()
        {
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int face = 1; face <= 13; face++)
                {
                    PokerModel pokerModel = new PokerModel();
                    pokerModel.face = face;
                    pokerModel.suit = suit;
                    pokerModel.isBack = true;
                    cardList.Add(pokerModel);
                }
            }
        }

        void updateButtonImage(Button button)
        {
            PokerModel poker = (PokerModel)button.Tag;
            button.BackgroundImage = getImageByPoker(poker);
            button.BackgroundImageLayout = ImageLayout.Zoom;//Zoom可縮放
            button.Visible = !poker.isHide;//若isHide為true，則不顯示牌
        }

        void updateAllButtonImage()
        {
            foreach (Button button in buttonList)
            {
                updateButtonImage(button);
            }
        }

        private void cardTimer_Tick(object sender, EventArgs e)
        {
            cardTimer.Stop();
            updateAllButtonImage();
            isWaiting = false;

            if (matchCount == cardList.Count / 2)
            {
                spendTimer.Stop();
                MessageBox.Show("恭喜你完成! 花費了" + spendtime + "秒");
            }
        }

        private void spendTimer_Tick(object sender, EventArgs e)
        {
            spendtime++;
            currentSpendLabel.Text = spendtime.ToString() + "秒";
        }
    }
}
