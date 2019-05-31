using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp22
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string dirt = "C:\\Users\\com\\Pictures\\땅.png";
        string face = "C:\\Users\\com\\Pictures\\웃는얼굴.png";
        private Tile[,] map=new Tile[10, 10];
        public MainWindow()
        {
            InitializeComponent();
            initArray();
            setTileData();
            generateTile();
        }

        private void initArray()
        {
            for(int i=0; i<10; i++)
            {
                for (int j = 0; j < 10; j++)
                    map[i, j] = new Tile();
            }
        }

        private void setTileData() //타일 정보 저장
        {
            Random rand = new Random();
            int tmp;
            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    tmp = rand.Next(0, 2);
                    if (tmp == 0)
                        map[i, j].ImgSource = dirt;
                    else if (tmp == 1)
                        map[i, j].ImgSource = face;
                }
            }
        }

        private void generateTile()
        {
            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    Image img = new Image();
                    
                    img.Source = new BitmapImage(new Uri(map[i,j].ImgSource));

                    Grid.SetColumn(img, i);
                    Grid.SetRow(img, j);

                    mapGrid.Children.Add(img);
                }
            }
        }
    }
}
