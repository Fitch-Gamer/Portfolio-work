using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Line_matcher
{
    public partial class Form1 : Form
    {
        public static Image RawMap;
        private static readonly ImageConverter _imageConverter = new ImageConverter();
        public Form1()
        {
            InitializeComponent();
        }

        private void ImgBut_Click(object sender, EventArgs e)
        {
            ImgFile.ShowDialog();
            RawMap = Image.FromFile(ImgFile.FileName);
            Bitmap ScaledImg = new Bitmap(RawMap, new Size(RawImg.Width, RawImg.Height));
            RawImg.Image = ScaledImg;
            //RawImg.Scale(new SizeF(0.5f,0.5f));

        }

        private void ProcBut_Click(object sender, EventArgs e)
        {
            Bitmap WhiteBitMap = new Bitmap(RawMap);
          
            for (int x = 0; x < WhiteBitMap.Width; x++)
            {
                for (int y = 0; y < WhiteBitMap.Height; y++)
                {
                    Color pixel = WhiteBitMap.GetPixel(x, y);
                    //WhiteBitMap.SetPixel(x, y, Color.White);
                    if(pixel.GetBrightness()*100 > float.Parse(MinRange.Text))//(pixel.R> int.Parse(MinRange.Text) && pixel.G > int.Parse(MinRange.Text) && pixel.B > int.Parse(MinRange.Text)) && (pixel.R < int.Parse(MaxRange.Text) && pixel.G < int.Parse(MaxRange.Text) && pixel.B < int.Parse(MaxRange.Text)))
                    {
                        WhiteBitMap.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        WhiteBitMap.SetPixel(x, y, Color.Black);
                    }
                }
            }
            Bitmap ScaledImg = new Bitmap(WhiteBitMap, new Size(WhiteImg.Width, WhiteImg.Height));
            WhiteImg.Image = ScaledImg;

            Bitmap Processed1 = ChunkRemoval(WhiteBitMap);
            Bitmap ScaledImg1 = new Bitmap(Processed1, new Size(WhiteImg.Width, WhiteImg.Height));
            PicBlockRem1.Image = ScaledImg1;

            Bitmap Processed2 = OtherChunkRemoval(Processed1);
            Bitmap ScaledImg2 = new Bitmap(Processed2, new Size(WhiteImg.Width, WhiteImg.Height));
            PicBlockRem2.Image = ScaledImg2;



            //Bitmap Removed = ChunkRemoval(WhiteBitMap);

        }

        private Bitmap ChunkRemoval(Bitmap RawWhiteMap)
        {
            
            
            int Radius = int.Parse(MaxRange.Text);
            int RemCount = int.Parse(CountBox.Text);
            bool[,] RemovedPixels = new bool[RawWhiteMap.Width,RawWhiteMap.Height];
            bool[,] MapArr = new bool[RawWhiteMap.Width, RawWhiteMap.Height];

            for (int x = 0; x < RawWhiteMap.Width; x++)
            {
                for (int y = 0; y < RawWhiteMap.Height; y++)
                {
                    if(RawWhiteMap.GetPixel(x,y).GetBrightness() == 1)
                    {
                        MapArr[x,y] = true;
                    }
                    else
                    {
                        MapArr[x,y] = false;
                    }
                }
            }

            for (int x = Radius; x < RawWhiteMap.Width-Radius; x++)
            {
                for (int y = Radius; y < RawWhiteMap.Height-Radius; y++)
                {   
                    int count = 0;
                    if (MapArr[x, y]) 
                    { count++; }

                    for (int tmp = Radius; tmp>0; tmp--)
                    {
                        if (MapArr[x + tmp, y + tmp]) { count++; }
                        if (MapArr[x - tmp, y + tmp]) { count++; }
                        if (MapArr[x + tmp, y - tmp]) { count++; }
                        if (MapArr[x - tmp, y - tmp]) { count++; }

                        if (MapArr[x , y + tmp]) { count++; }
                        if (MapArr[x , y - tmp]) { count++; }
                        if (MapArr[x + tmp , y]) { count++; }
                        if (MapArr[x - tmp , y]) { count++; }
                    }
                    if(count >= RemCount)
                    {
                        RemovedPixels[x, y] = true;
                    }
                    else
                    {
                        RemovedPixels[x,y] = false;
                    }
                    
                }
            }
            bool changed = true;
            while (changed)
            {
                changed = false;
                for (int x = 1; x < RawWhiteMap.Width - 1; x++)
                {
                    for (int y = 1; y < RawWhiteMap.Height - 1; y++)
                    {
                        if (RawWhiteMap.GetPixel(x, y).GetBrightness() == 1 && (RemovedPixels[x + 1, y] || RemovedPixels[x - 1, y] || RemovedPixels[x, y + 1] || RemovedPixels[x, y - 1] || RemovedPixels[x + 1, y - 1] || RemovedPixels[x - 1, y - 1] || RemovedPixels[x + 1, y + 1] || RemovedPixels[x - 1, y + 1]))
                        {
                            RemovedPixels[x, y] = true;
                            //changed = true;
                            //RawWhiteMap.SetPixel(x, y,Color.Black);
                        }
                    }
                }
            }

            for (int x = 1; x < RawWhiteMap.Width - 1; x++)
            {
                for (int y = 1; y < RawWhiteMap.Height - 1; y++)
                {
                    if (RemovedPixels[x, y])
                    {
                        RawWhiteMap.SetPixel(x, y,Color.Black);
                    }
                }
            }

            return RawWhiteMap;
            
        }

        private Bitmap OtherChunkRemoval(Bitmap RawWhiteMap)
        {
            bool[,] RawCol = new bool[RawWhiteMap.Width, RawWhiteMap.Height];
            int MaxWhites = int.Parse(PixelNum.Text);
            for (int x = 0; x < RawWhiteMap.Width; x++)
            {
                for (int y = 0; y < RawWhiteMap.Height; y++)
                {
                    RawCol[x, y] = RawWhiteMap.GetPixel(x, y).R == 255;
                }
            }

            for (int x = 0; x < RawWhiteMap.Width; x++)
            {
                for (int y = 0; y < RawWhiteMap.Height; y++)
                {
                    if (RawCol[x, y])
                    {
                        RawCol[x, y] = false;
                        List<Vector2> Locations = new List<Vector2>();
                        Locations.Add(new Vector2(x, y));
                        int LocCount = 0;
                        while (LocCount < Locations.Count())
                        {
                            try
                            {
                                if (RawCol[Locations[LocCount].X, Locations[LocCount].Y + 1])
                                {
                                    Locations.Add(new Vector2(Locations[LocCount].X, Locations[LocCount].Y + 1));
                                    RawCol[Locations[LocCount].X, Locations[LocCount].Y + 1] = false;
                                }

                            }
                            catch { }

                            try
                            {
                                if (RawCol[Locations[LocCount].X, Locations[LocCount].Y - 1])
                                {
                                    Locations.Add(new Vector2(Locations[LocCount].X, Locations[LocCount].Y - 1));
                                    RawCol[Locations[LocCount].X, Locations[LocCount].Y - 1] = false;
                                }

                            }
                            catch { }

                            try
                            {
                                if (RawCol[Locations[LocCount].X + 1, Locations[LocCount].Y + 1])
                                {
                                    Locations.Add(new Vector2(Locations[LocCount].X + 1, Locations[LocCount].Y + 1));
                                    RawCol[Locations[LocCount].X + 1, Locations[LocCount].Y + 1] = false;
                                }

                            }
                            catch { }

                            try
                            {
                                if (RawCol[Locations[LocCount].X + 1, Locations[LocCount].Y - 1])
                                {
                                    Locations.Add(new Vector2(Locations[LocCount].X + 1, Locations[LocCount].Y - 1));
                                    RawCol[Locations[LocCount].X + 1, Locations[LocCount].Y - 1] = false;
                                }

                            }
                            catch { }

                            try
                            {
                                if (RawCol[Locations[LocCount].X - 1, Locations[LocCount].Y - 1])
                                {
                                    Locations.Add(new Vector2(Locations[LocCount].X - 1, Locations[LocCount].Y - 1));
                                    RawCol[Locations[LocCount].X - 1, Locations[LocCount].Y - 1] = false;
                                }

                            }
                            catch { }

                            try
                            {
                                if (RawCol[Locations[LocCount].X - 1, Locations[LocCount].Y + 1])
                                {
                                    Locations.Add(new Vector2(Locations[LocCount].X - 1, Locations[LocCount].Y + 1));
                                    RawCol[Locations[LocCount].X - 1, Locations[LocCount].Y + 1] = false;
                                }

                            }
                            catch { }

                            try
                            {
                                if (RawCol[Locations[LocCount].X - 1, Locations[LocCount].Y])
                                {
                                    Locations.Add(new Vector2(Locations[LocCount].X - 1, Locations[LocCount].Y));
                                    RawCol[Locations[LocCount].X - 1, Locations[LocCount].Y] = false;
                                }

                            }
                            catch { }

                            try
                            {
                                if (RawCol[Locations[LocCount].X + 1, Locations[LocCount].Y])
                                {
                                    Locations.Add(new Vector2(Locations[LocCount].X + 1, Locations[LocCount].Y));
                                    RawCol[Locations[LocCount].X + 1, Locations[LocCount].Y] = false;
                                }

                            }
                            catch { }
                            LocCount++;
                        }

                        if (Locations.Count >= MaxWhites)
                        {
                            foreach (Vector2 v in Locations)
                            {
                                RawWhiteMap.SetPixel(v.X, v.Y, Color.Black);
                            }

                        }

                    }

                }
            }
            return RawWhiteMap;
        }

        public class Vector2
        {
            public int X, Y;
            public Vector2(int x, int y)
            {
                X=x; Y=y;
            }
            
        }

    }
}
