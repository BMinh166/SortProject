﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualiser_v1
{
    public class HienThiThuatToan
    {
        #region Một số biến toàn cục
        //public static ListBox codeListBox;
        public static TextBox yTuongThuatToan;
        public static string yTuongVi;
        public static string yTuongEn;
        public static string algorithm;
        public static bool isEn = false;
        public static int number;
        public static ManualResetEvent tamdung = new ManualResetEvent(true);
        public static event EventHandler RichTextBoxChange;
        #endregion

        public static string[] ChuyenText(string doc)
        {
            string[] text;
            text = doc.Split('\n');//Cac string den xuong dong
            return text;
        }

        public static void ChayCodeC(int line)
        {
            Thread.Sleep(ThamSo.ThoiGianDoi * 50);
            // chờ sign nếu có thì đợi đến vô tận 
            tamdung.WaitOne(Timeout.Infinite);

            //codeListBox.SelectedIndex = line;
            number = line;
            RichTextBoxChange?.DynamicInvoke(number, EventArgs.Empty);
            if (fMain.isDebug == true)
            {
                tamdung.Reset();
            }
        }

        #region Hàm add Ý Tưởng
        private static void addYTuong()
        {
            //yTuongThuatToan.Clear();
            if (fMain.isEnglish == true)
            {
                yTuongThuatToan.Text = yTuongEn;                
            }
            else if (fMain.isEnglish == false)
            {
                yTuongThuatToan.Text = yTuongVi;
            }
        }


        #region Phân loại sort 
        //Phân loại sort
        public static void Type_Sort() 
        {
            switch(fMain.typeSort)
            {
                case 0:
                    BubbleSort(fMain.isIncrease);
                    break;
                case 1:
                    InterchangeSort(fMain.isIncrease);
                    break;
                case 2:
                    BinaryInsertionSort(fMain.isIncrease);
                    break;
                case 3:
                    InsertionSort(fMain.isIncrease);
                    break;
                case 4:
                    SelectionSort(fMain.isIncrease);
                    break;
                case 5:
                    HeapSort(fMain.isIncrease);
                    break;
                case 6:
                    MergeSort(fMain.isIncrease);
                    break;
                case 7:
                    QuickSort(fMain.isIncrease);
                    break;
            }
                
        }
        #endregion

        #endregion

        #region Hiển thị từng loại thuật toán

        #region Insertion Sort
        public static void InsertionSort(bool tang = true)
        {
            //Vietnamese
            yTuongVi =
@"Giả sử có một dãy a0, a1,... ,an-1 trong đó i phần tử đầu tiên a0, a1,... ,ai-1 đã có thứ tự.
Tìm cách chèn phần tử ai vào vị trí thích hợp của đoạn đã được sắp để có dãy mới a0, a1,... ,ai trở nên có thứ tự. Vị trí này chính là vị trí giữa hai phần tử ak-1 và ak thỏa ak-1 < ai < ak(1≤k≤i).";
            //English
            yTuongEn = @"• Start by considering the first two elements of the array data. If found out of order, swap them
• Consider the third element; insert it into the proper position among the first three elements.
• Consider the fourth element; insert it into the proper position among the first four elements.
• … …";
            // Thêm yTuong vào yTuongThuatToan
            //addYTuong();

            algorithm =
@"void InsertionSort(int a[], int N)
{
    int pos, i;
    int x;
    for(i = 1; i < N; i++)
    {
        x = a[i]; pos = i - 1;
        while((pos >= 0) && (x < a[pos]))
        {
            a[pos + 1] = a[pos];
            pos--;
        }
        a[pos + 1] = x;
    }
}";

            if (!tang)
            {
                algorithm =
@"void InsertionSort(int a[], int N)
{
    int pos, i;
    int x;
    for(i = 1; i < N; i++)
    {
        x = a[i]; pos = i - 1;
        while((pos >= 0) && (x > a[pos]))
        {
            a[pos + 1] = a[pos];
            pos--;
        }
        a[pos + 1] = x;
    }
}";
            }
        }
        #endregion

        #region Selection Sort
        public static void SelectionSort(bool tang = true)
        {
            //vietnamese
            yTuongVi =
 @"Chọn phần tử nhỏ nhất trong N phần tử trong dãy hiện hành ban đầu.
Đưa phần tử này về vị trí đầu dãy hiện hành.
Xem dãy hiện hành chỉ còn N-1 phần tử của dãy hiện hành ban đầu.
Bắt đầu từ vị trí thứ 2;
Lặp lại quá trình trên cho dãy hiện hành... đến khi dãy hiện hành chỉ còn 1 phần tử.";
            //English
            yTuongEn = @"• find the smallest element 
• put it in the first position
• find the next smallest element in the remaining elements
• put it in the second position
• …
• And so on, until we get to the end of the array";
            //Thêm yTuong vào yTuongThuatToan
            //addYTuong();


            algorithm =
@"void SelecttionSort(int arr[], int N)
{
    int min, i, j;
    for (i=0; i < N-1; i++)
        {
             min = i;
             for (j=i+1; j <N; j++)
             if (a[j] < a[min])
                 min=j;
                 Swap(a[min], a[i]);   
        } 
}";

            //Nếu sắp xếp giảm dần thì sửa lại
            if (!tang)
            {
                algorithm =
@"void SelecttionSort(int arr[], int N)
{
    int min, i, j;
    for (i=0; i < N-1; i++)
        {
             min = i;
             for (j=i+1; j <N; j++)
             if (a[j] > a[min])
                 min=j;
                 Swap(a[min], a[i]);   
        } 
}";
            }
        }
        #endregion

        #region Quick Sort
        public static void QuickSort(bool tang = true)
        {
            //Vietnamese
            yTuongVi =
@"Giải thuật QuickSort sắp xếp dãy a1, a2 ..., aN dựa trên việc phân hoạch dãy ban đầu thành 3 phần :
Phần 1:Gồm các phần tử  có giá trị bé hơn x
Phần 2: Gồm các phần tử  có giá trị bằng  x 
Phần 3: Gồm các phần tử  có giá trị lớn hơn x
Với x là giá trị của một phần tử  tùy ý trong dãy ban đầu.";
            //English
            yTuongEn = @"If the number of elements in S is 0 or 1, then
return (base case).
• Pick any element v in S (called the pivot).
• Partition the elements in S except v into two
disjoint groups:
    • S1 = {x ∈ S – {v} | x ≤ v}
    • S2 = {x ∈ S – {v} | x ≥ v}
•  Return {QuickSort(S1) + v + QuickSort(S2)}";
            //Thêm yTuong vào yTuongThuatToan
            //addYTuong();

            algorithm =
@"void QuickSort(int a[], int left, int right)
{
    int i, j, x;
    x = a[(left + night)/2];
    i = left, j = right;
    do
    {
        while(a[i] < x)
            i++;
        while(x < a[j])
            j--;
        if(i <= j)
        {
            Swap(a[i], a[j]);
            i++, j--;
        }            
    }while(i <= j);
    if(left < j)
        QuickSort(a, left, j);
    if(i < right)
        QuickSort(a, i, right);
}";

            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                algorithm =
@"void QuickSort(int a[], int left, int right)
{
    int i, j, x;
    x = a[(left + night)/2];
    i = left, j = right;
    do
    {
        while(a[i] > x)
            i++;
        while(x > a[j])
            j--;
        if(i <= j)
        {
            Swap(a[i], a[j]);
            i++, j--;
        }            
    }while(i <= j);
    if(left < j)
        QuickSort(a, left, j);
    if(i < right)
        QuickSort(a, i, right);
}";
            }
        }
        #endregion

        #region Interchange Sort
        public static void InterchangeSort(bool tang = true)
        {
            //Vietnamese
            yTuongVi =
@"Xuất phát từ đầu dãy, tìm tất các các nghịch thế chứa phần tử này, triệt tiêu chúng bằng cách đổi chỗ 2 phần tử trong cặp nghịch thế. Lặp lại xử lý trên với phần tử kế trong dãy.";
            //English
            yTuongEn = @"• Find the smallest number in the set and interchange it with the number in the first position.
• Then find the second smallest number, and swap it with the number in the second position.
• So on.";
            //Thêm yTuong vào yTuongThuatToan
            //addYTuong();

            algorithm =
@"void InterchangeSort( int a[], int N)
{
    int i, j;
    for(i = 0; i < N - 1; i++)
        for(j = i + 1; j < N; j++)
            if( a[j] < a[i] )
                Swap( a[i], a[j]);
}";

            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                algorithm =
@"void InterchangeSort( int a[], int N)
{
    int i, j;
    for(i = 0; i < N - 1; i++)
        for(j = i + 1; j < N; j++)
            if( a[j] > a[i] )
                Swap( a[i], a[j]);
}";
            }
        }
        #endregion

        #region Binary Insertion Sort
        public static void BinaryInsertionSort(bool tang = true)
        {
            //Vietnamese
            yTuongVi =
@"Cải tiến của giải thuật InsertionSort. Giải thuật chèn nhị phân cho phép giảm số lần so sánh, nhưng không làm giảm số lần dời chỗ.";
            //English
            yTuongEn = @"• Use binary search to reduce the number of comparisons in normal insertion sort.
• Binary Insertion Sort find use binary search to find the proper location to insert the selected item at each iteration.";
            //Thêm yTuong vào yTuongThuatToan
            //addYTuong();

            algorithm =
@"void BinaryInsertionSort(int a[], int N)
{
   int left, right, m, i , pos;
   int x;
   for(int i = 1; i < N ; i++)
   {
      x = a[i]; left = 0; right = i - 1;
      while(left <= right)
      {
         m = (left + right)/2;
         if(x < a[m]) right = m - 1;
         else left = m + 1;                    
      }
      for(pos = i - 1; pos >= left; pos--)
         a[pos+1] = a[pos];
      a[left] = x;
    }
}";
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                algorithm =
@"void BinaryInsertionSort(int a[], int N)
{
   int left, right, m, i , pos;
   int x;
   for(int i = 1; i < N ; i++)
   {
      x = a[i]; left = 0; right = i - 1;
      while(left <= right)
      {
         m = (left + right)/2;
         if(x > a[m]) right = m - 1;
         else left = m + 1;                    
      }
      for(pos = i - 1; pos >= left; pos--)
         a[pos+1] = a[pos];
      a[left] = x;
    }
}";
            }
        }
        #endregion

        #region Bubble Sort
        public static void BubbleSort(bool tang = true)
        {
            //Vietnamese
            yTuongVi =
@"Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn trong cặp phần tử đó về vị trí đúng đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo, do vậy ở lần xử lý thứ i sẽ có vị trí đầu dãy là i. 
Lặp lại xử lý trên cho đến khi không còn cặp phần tử nào để xét.";
            //English
            yTuongEn = @"• Exchange neighboring items until the largest item reaches the end of the array.
• Repeat the above step for the rest of the array.";
            //Thêm yTuong vào yTuongThuatToan
            //addYTuong();

            algorithm =
@"void BubbleSort(int a[], int N)
{
   int i,j;
   for(i = 0; i < N - 1; i++)
      for(j = N - 1; j > i; j--)
        if(a[j] < a[j - 1])
            Swap(a[j], a[j - 1]);
}
";
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                algorithm =
@"void BubbleSort(int a[], int N)
{
   int i,j;
   for(i = 0; i < N - 1; i++)
      for(j = N - 1; j > i; j--)
        if(a[j] > a[j - 1])
            Swap(a[j], a[j - 1]);
}
";
            }
        }
        #endregion

        #region Heap Sort
        public static void HeapSort(bool tang = true)
        {
            //Vietnamese
            yTuongVi =
@"Heap Sort tận dụng được các phép so sánh ở bước i-1, mà thuật toán sắp xếp chọn trực tiếp (Selectin Sort) không tận dụng được.
Để làm được điều này Heap sort thao tác dựa trên cây.";
            //English
            yTuongEn = @"• Transform the array of items into a heap.
• Invoke the “retrieve & delete” operation repeatedly, to extract the largest item remaining in the heap, until the heap is empty.  Store each item retrieved from the heap into the array from back to front.";
            //Thêm yTuong vào yTuongThuatToan
            //addYTuong();

            algorithm =
@"void HeapSort(int a[], int N)
{
    CreateHeap(a,N - 1);
    int r;
    r = N - 1;
    while(r >= 0)
    {
        Swap(a[0], a[r]);
        r--;
        if(r > 0 )
            Shift(a,0,r);
    }
}

void CreateHeap(int a[], int N)
{
    int l;
    l = N/2 - 1;
    while(l >= 0)
    {
        Shift(a,l,N - 1);
        l--;
    }
}

void Shift(int a[], int l, int r)
{
    int i = l;
    int j = 2*i + 1;
    while(j <= r)
    {
        if(j < r && a[j] < a[j+1]) 
            j++;
        if(a[i] < a[j])
        {
            Swap(a[i], a[j]);
            i = j; 
            j = 2*i + 1;
        }
        else return;
    }
}";
            ////nếu sắp giảm thì sửa lại
            //if (!tang)
            //{

            //}
        }
        #endregion

        #region Merge Sort
        public static void MergeSort(bool tang = true)
        {
            //Vietnamese
            yTuongVi =
@"Sắp xếp dãy a(1),a(2),...,a(n) dựa trên nhận xét sau :
-Mỗi dãy a(1),a(2),...,a(n) bất kỳ là một tập hợp các dãy con liên tiếp mà mỗi dãy con đều đã có thứ tự. 
-Dãy đã có thứ tự coi như có 1 dãy con.           
Hướng tiếp cận : tìm cách làm giảm số dãy con không giảm của dãy ban đầu.";
            //English
            yTuongEn = @"• Divide the array into two halves.
• Conquer each half by sorting it recursively
• Combine the results obtained, by merging the two halves to obtain one fully sorted array";
            //Thêm yTuong vào yTuongThuatToan
            //addYTuong();

            algorithm =
@"int b[MAX], c[MAX], nb, nc;
int Min(int a, int b)
{
    if(a > b) return b;
    else return a;
}
void Distribute(int a[], int N, int &nb, int &nc, int k)
{
    int i, pa, pb, pc;
    pa = pb = pc = 0 ;
    while(pa < N)
    {
        for(i = 0; (pa < N) && (i < k); i++, pa++, pb++)
            b[pb] = a[pa];
        for(i = 0; (pa < N) && (i < k); i++, pa++, pc++)
            c[pc] = a[pa];
    }
    nb = pb; nc = pc;
}
void Merge(int a[], int nb, int nc, int k)
{
    int p, pb, pc, ib, ic, kb, kc;
    p = pb = pc = 0; ib = ic = 0;
    while((nb > 0) && (nc > 0))
    {
        kb = Min(k, nb); kc = Min(k, nc);
        if(c[pc + ic] < b[pb + ib] == false)
        {
            a[p++] = b[pb + ib]; ib++;
            if(ib == kb)
            {
                for(;ic < kc; ic++)
                    a[p++] = c[pc + ic];
                pb += kb; pc += kc; ib = ic = 0;
                nb -= kb; nc -= kc;
            }
        }
        else
        {
            a[p++] = c[pc + ic]; ic++;
            if(ic == kc)
            {
                for(;ib < kb; ib++)
                    a[p++] = b[pb + ib];
                pb += kb; pc += kc; ib = ib = 0;
                nb -= kb; nc -= kc;
            }
        }
    }
}
void MergeSort(int a[], int N)
{
        int k;
        for(k = 1; k < N; k*= 2)
        {
            Distribute(a, N, nb, nc, k);
            Merge(a, nb, nc, k);
        }
}
";
            //nếu sắp giảm thì sửa lại
            if (!tang)
            {
                algorithm =
@"int b[MAX], c[MAX], nb, nc;
int Min(int a, int b)
{
    if(a > b) return b;
    else return a;
}
void Distribute(int a[], int N, int &nb, int &nc, int k)
{
    int i, pa, pb, pc;
    pa = pb = pc = 0 ;
    while(pa < N)
    {
        for(i = 0; (pa < N) && (i < k); i++, pa++, pb++)
            b[pb] = a[pa];
        for(i = 0; (pa < N) && (i < k); i++, pa++, pc++)
            c[pc] = a[pa];
    }
    nb = pb; nc = pc;
}
void Merge(int a[], int nb, int nc, int k)
{
    int p, pb, pc, ib, ic, kb, kc;
    p = pb = pc = 0; ib = ic = 0;
    while((nb > 0) && (nc > 0))
    {
        kb = Min(k, nb); kc = Min(k, nc);
        if(c[pc + ic] > b[pb + ib] == false)
        {
            a[p++] = b[pb + ib]; ib++;
            if(ib == kb)
            {
                for(;ic < kc; ic++)
                    a[p++] = c[pc + ic];
                pb += kb; pc += kc; ib = ic = 0;
                nb -= kb; nc -= kc;
            }
        }
        else
        {
            a[p++] = c[pc + ic]; ic++;
            if(ic == kc)
            {
                for(;ib < kb; ib++)
                    a[p++] = b[pb + ib];
                pb += kb; pc += kc; ib = ib = 0;
                nb -= kb; nc -= kc;
            }
        }
    }
}
void MergeSort(int a[], int N)
{
        int k;
        for(k = 1; k < N; k*= 2)
        {
            Distribute(a, N, nb, nc, k);
            Merge(a, nb, nc, k);
        }
}
";
            }
        }
        #endregion

        #endregion

    }
}
