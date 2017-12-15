using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public class Sudoku
    {
        private int[,] sdk;
        public int[,] Sdk
        {
            get { return sdk; }
            set { sdk = value; }
        }
        private int n;
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        private int dem=0;
        public int Dem
        {
            get { return dem; }
            set { dem = value; }
        }
        public Sudoku(int[,] M)
        {
            sdk = new int[9, 9];
            n = 9;
            Chuyende(M);
        }
        private void Chuyende(int[,] M)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (M[i, j * 2] != 0 && M[i, j * 2 + 1] == 0) sdk[j, i] = M[i, j * 2];
                    else sdk[j, i] = 0;
                }
            }
        }
        public Sudoku()
        {
            sdk = new int[9, 9];
            n = 9;
            createSDK();
        }
        /// <summary>
        /// Đếm Số Lượng ô trống
        /// </summary>
        public void DemSoLuong()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sdk[i, j] == 0)
                    {
                        dem++;
                    }
                }
            }
        }
        /// <summary>
        /// Khởi tạo đề bài sudoku
        /// </summary>
        public void createSDK()
        {
            khoitao();
            ran(20);
        }
        public void xuat()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("  {0}", sdk[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void ran(int solan)
        {
            Random r1 = new Random(Guid.NewGuid().GetHashCode());
            Random r2 = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < solan; i++)
            {
                swap(r1.Next(1, 9), r2.Next(1, 9));
            }
        }
        /// <summary>
        /// Xóa bỏ các ô để tạo đề bài
        /// </summary>
        public void Remove()
        {
            int i = 0;
        
            Random r1 = new Random(Guid.NewGuid().GetHashCode());
            switch (level)
            {
                case 1:
                    level = r1.Next(30);
                    break;
                case 2:
                    level = r1.Next(40, 45);
                    break;
                case 3:
                    level = r1.Next(48, 53);
                    break;
                case 4:
                    level = r1.Next(65, 70);
                    break;
                case 5:
                    level = r1.Next(70, 75);
                    break;
            }
            Random r2 = new Random(Guid.NewGuid().GetHashCode());
            while (i <= level)
            {
                int k;
                int j;
                do
                {
                    k = r1.Next(9);
                    j = r2.Next(9);
                } while (sdk[k,j] == 0);
                sdk[k, j] = 0;
                i++;
            }
        }
        public void swap(int vt1, int vt2)
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            for (int i = 0; i < 9; i += 3)
            {
                for (int k = 0; k < 9; k += 3)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int z = 0; z < 3; z++)
                        {
                            if (sdk[i + j, k + z] == vt1)
                            {
                                x1 = i + j;
                                y1 = k + z;

                            }
                            if (sdk[i + j, k + z] == vt2)
                            {
                                x2 = i + j;
                                y2 = k + z;

                            }
                        }
                    }
                    sdk[x1, y1] = vt2;
                    sdk[x2, y2] = vt1;
                }
            }
        }
        /// <summary>
        /// Lấp đầy các ô số
        /// </summary>
        public void khoitao()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sdk[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sdk[i, j]);
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Giải sudoku
        /// </summary>
        public void Solution()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sdk[i, j]);
                }
                Console.WriteLine();
            }
            int kdau = timodau();
            Stack S = new Stack(100);
            int sc = timocuoi();
            if (sc == -1)
            {
                Application.Exit();
            }
            int k = kdau;
            int tam = 0;
            int so = 1;
            while (k <= sc)
            {
                while (sdk[k / n, k % n] != 0)
                    k++;
       
                for (; so <= n; so++)
                {
                    if (ktX(so, k / n, k % n))
                    {
                        sdk[k / n, k % n] = so;
                        S.Push(k);
                        k++;
                        so = 1;
                        break;
                    }
                    if (k ==kdau&&so==9)
                    {
                        MessageBox.Show("Game Over\n de bai sai","Error");
                        Environment.Exit(1);
                    }
                    if (so == n)
                    {
                        do
                        {
                            k = S.Pop();
                            tam = sdk[k / n, k % n];
                            if (tam < n)
                            {
                                so = tam;
                            }
                            else
                            {
                                so = 1;
                            }

                            sdk[k / n, k % n] = 0;
                        } while (tam == n);
                    }
                }

            }
        }
        private int timodau()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (sdk[i,j]==0)
                    {
                        return (i * n + j);
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// Tìm ô cuối cùng cần điền
        /// </summary>
        /// <returns>ô trống cuối cùng</returns>
        public int timocuoi()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (sdk[i, j] == 0)
                        return (i * n + j);
                }
            }
            return -1;
        }
        /// <summary>
        /// Kiểm tra X khi điền vào ô [i][j] có thỏa các điều kiện của sudoku hay không
        /// </summary>
        /// <param name="x">Số được điền</param>
        /// <param name="i">Hàng</param>
        /// <param name="j">Cột</param>
        /// <returns>Kết quả kiểm tra:true nếu như thỏa ỏ false nếu vi phạm 1 trong các điều kiện có sẵn</returns>
        public bool ktX(int x, int i, int j)
        {
            int k, t, m, p;
            for (k = 0; k < n; k++)
                if (sdk[i, k] == x) return false;
            for (t = 0; t < n; t++)
                if (sdk[t, j] == x) return false;
            m = i % (int)Math.Sqrt(n);
            p = j % (int)Math.Sqrt(n);
            for (k = i - m; k <= i - m + (int)Math.Sqrt(n) - 1; k++)
                for (t = j - p; t <= j - p + (int)Math.Sqrt(n) - 1; t++)
                    if (sdk[k, t] == x) return false;
            return true;
        }

    }
}
