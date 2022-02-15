using System;

namespace Exception_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            /*
             
            .חגירה זה בעצם שגיאה בקוד שלך הגורמת לתוכנה לקרוס
            
            .חריגה בזמן קימפול - חריגה שהקומפיילר מזהה אותה לפני הרצת התוכנית כמו לחלק מספר באפס
            
           .חגירה בזמן ריצה - חריגה שהקומפיילר לא זיהה בזמן כתיבת הקוד כמו למשל לחלק מספר במשתנה שהערך שלו הוא אפס, שמקריסה את התוכנית שלנו
            

            */

            #endregion


            #region Question 2

            /*

            2a:
            במידה והחריגה לא מתופלת התוכנית שלנו תקרוס והשורות קוד שנכתבו אחרי השגיאה לא יחשבו

            2b:
            במידה והחריגה מתופלת היא תמשיך לשורת הקוד הבאה שנגיד לה 

            */

            #endregion


            #region Question 3

            /*
             
            ניתן לשהשתמש ב try או catch
            או להתשמש בתנאים כמו if ו else

            */
            #endregion


            #region Question 4

            /*
             
            4a:
            היא לבדוק אם בבלוק פקודות שלה יש איזושהי שגיאה ואם כן לתפל בה, אם לא ממשיכה כרגילtry מטרת הבלוק 

            4b:
         try היא לתפל בשגיאה שקרתה ב גבלוק של ה  catct מטרת הבלוק 

            4c:
          היא לבצע פקודה בכל מקרה אם הייתה שגיאה או לא  finally מטרת הבלוק 

            */

            #endregion


            #region Question 5

            /*

       ApplicationException ו StstemExcaption  הם Exceptions הבנים של המחלקה 

          היא מחלקה בעצם שנועדה להגדיר חריגות שאנחנו יצרנו ולא חריגות שהמערכת כבר יצרה בשבילנו ApplicationException ההבדל ביניהם הוא ש 
            
            */
            #endregion


            #region Question 6

            /*

         המתאים לו ויבצע את הפעולות שרשומות בבלוק שלו catchהקומפיילר ישר יחפש את ה try לא, ברגע שניתקל בחריגה בתוך הבלוק של ה 

            */
            #endregion


            #region Question 7

            /*

          אם נרצה לבצע מספר שורות קוד במידה והייתה שגיאה או לא finally נשתמש ב

            */
            #endregion


            #region Question 8

            /*

            try בדיקה אם יכול להיות יש שגיאות נוספות בבלוק של ה

            */
            #endregion


            #region Question 9

            /*

            כאשר נרצה לגלות בדיוק באיזה שורת קודם ובאיזה פרוייקט בדיוק קרה השגיאה

            */
            #endregion


            #region Question 10

            /*
             
          Exception של המחלקה  ApplicationException כמו מחלקה רגילה אפשר ליצור מחלקה של חריגה שתירש מהמחלקת הבת 
            
            */
            #endregion


            #region Question 11

            /*

            כדאי לרשום בדיוק מה גורם לבעיה שבשבילה יצרנו את החריגה 

            */
            #endregion


            #region Question 12

            /*

        catchחייב להשתמש גם ב ,finally ו try אי אפשר להשתמש רק ב 
            
            */
            #endregion


            #region Question 13

            /*

            מחלקה שאנחנו יוצרים, נשתמש בה כאשר נרצה לעשות בדיקות אישיות על המחלקות שלנו

            */
            #endregion


            #region Question 14

            /*

           ApplicationException אנחנו נירש מהמחלקה 
        Exception שניהם יביאו לנו את אותם תוצאות כי שתיהן יורשות מהמחלקה  SystemExceptionאו מ ApplicationException זה לא באמת משנה אם נירש מ 
          כדי שיהיה לנו את החלוקה בין חריגות שאנחנו יצרנו לבין חריגות שהמערכת כבר יצרה ApplicationException לדעתי המחלקה הנכונה יותר שנירש ממנה היא 
            
            */

            #endregion


            #region Question 15

            /*

        כדי לבדוק איזה תנאי בחריגה ,if משמשת כמו הפונקציה 

            */
            #endregion


            #region Question 16

            string[] Repairable = { "Mazda", "Toyota", "Hyundai", "Honda", "Kia" };

            Car c1 = new Car("Mazda", false, true);
            Car c2 = new Car("Honda", false, true);
            Car c3 = new Car("Kia", true, true);
            Car c4 = new Car("Mustang", false, true);

            Garage g1 = new Garage(Repairable);

            g1.AddCar(c1);
            g1.FixCar(c1);

            g1.AddCar(c2);
            
            




            #endregion















        }
    }
}
