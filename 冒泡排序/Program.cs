using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组类型[] 数组名=new 数组类型[数组长度];
            //int[] nums = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] nums = new int[] { 56, 45, 23, 12, 54, 76, 32, 87, 32, 21 };
            //让第一个数依次和后面的数进行比较，大于则交换位置
            //第一趟比较：8,7,6,5,4,3,2,1,0,9 交换了9次
            //第二趟比较：7,6,5,4,3,2,1,0,8,9 交换了8次
            //第三趟比较：6,5,4,3,2,1,0,7,8,9 交换了7次
            //第四趟比较：5,4,3,2,1,0,6,7,8,9 交换了6次
            //第五趟比较：4,3,2,1,0,5,6,7,8,9 交换了5次
            //第六趟比较：3,2,1,0,4,5,6,7,8,9 交换了4次
            //第七趟比较：2,1,0,3,4,5,6,7,8,9 交换了3次
            //第八趟比较：1,0,2,3,4,5,6,7,8,9 交换了2次
            //第九趟比较：0,1,2,3,4,5,6,7,8,9 交换了1次
            Console.WriteLine("数组的长度是{0}", nums.Length);
            Array.Sort(nums);//调用Array.array方法来对数组进行从小到大的排序
            //如果要从大到小的话，只需要升序再反转就行了

            Array.Reverse(nums);//调用Array.Reverse方法来对数组进行反转
            

            //for (int i = 0; i < nums.Length - 1; i++)//i从0开始 比较9次 所以i<nums.Lenth-1
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)//nums.Length-1-i,是每次交换真正需要交换的次数。
            //                                             //虽说nums.Length-1但是这样会增加程序的运算量
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            Console.WriteLine("从小到大排序后的顺序为：");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+" ");
            }



            Console.ReadKey(true);
        }
    }
}
