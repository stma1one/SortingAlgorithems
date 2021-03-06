using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithems
{
   public class SortsMethods
    {
        #region Selection Sort
        /// <summary>
        ///  פעולה המקבלת מערך המכיל נתונים
        ///  הפעולה ממיינת את הנתונים מהקטן לגדול
        ///  הפעולה מוצאת בכל סיבוב את המיקום של הערך המינימלי 
        ///  מהמיקום האחרון שבו נמצא המינימום הקודם ועד סוף המערך
        ///  וממקמת אותו במיקום הנכון.
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = SortingHelpers.MinIndex(arr, i, arr.Length - 1);
                SortingHelpers.Swap(arr, minIndex, i);
            }
        }

        #endregion

        #region BubbleSort 

        /// <summary>
        /// הפעולה מקבלת מערך המכיל נתונים
        /// מעדכנת את המערך למערך ממויין בסדר עולה
        /// הפעולה סורקת בכל סיבוב ומבצעת החלפת מיקום בכל פעם שנתקלת בערך קטן
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            bool isSwap = false;
            //לולאה חיצונית מסוף המערך עד התא הראשון
            for(int i=arr.Length-1;i>0 && !isSwap; i--)
            {
                isSwap = true;
                for(int j=0;j<i;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        SortingHelpers.Swap(arr, j, j + 1);
                        isSwap = false;
                    }
                }

            }
            //לולאה פנימית מתא 0 עד המצביע של הלולאה החיצונית

        }
        #endregion

        #region Insertion Sort

        public static void InsertionSort(int[] arr)
        {
            for (int lastSorted =1; lastSorted < arr.Length; lastSorted++)
            {
                int current = arr[lastSorted];
                int i = 0;
                //למצוא את המיקום שאליו יש להכניס את הערך שנמצא ב
                //current
                while(i<lastSorted&&arr[i]<current)
                {
                    i++;
                }
                //i - מכיל את המיקום של התא שאליו current צריך להכנס
                SortingHelpers.Shift(arr, lastSorted, i);
                arr[i] = current;
            }
           

        }
         
        
        #endregion
    }
}
