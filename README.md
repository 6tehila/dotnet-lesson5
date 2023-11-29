# dotnet-lesson5
Web API for the Hotel:
נושא הפרויקט
מערכת לניהול מלון
תיאור :
פרויקט לניהול בית מלון הכולל תחזוק שותף של רשימת נופשים , חדרים בתפוסה, תאריכים פנויים, כך שניתן לערוך ולאפשר גישה מלאה למערכת הזו

ישויות:
-	נופשים
-	חדרי אירוח
-	תאריכים 

 מיפוי Routes  של אנשים(נופשים):
שליפת רשימת האנשים שעשו חבילת נופש במלון          Get http://hotel.co.il/Persons
שליפת אדם לפי הכנסת מס' זהות                 Get http:// hote_.co.il/Persons/1
הוספת אדם                                  Post http:// hotel.co.il/Persons
שליפת רשימת האנשים שעשו חבילת נופש במלון         Put http:// hotel.co.il/Persons
מחיקת אדם שנפש במלון                       Delete http:// hotel.co.il/Persons



 מיפוי Routes  של חדרי אירוח:
שליפת רשימת כל חדרי אירוח שקיימים במלון              Get http:// hotel.co.il/Rooms
שליפת חדר על פי המס' מזהה שלו                   Get http:// hotel.co.il/Rooms/1 
הוספת חדר                                     Post http:// hotel.co.il/Rooms  
עדכון חדר                                       Put http:// hotel.co.il/Rooms
מחיקת חדר  במלון                              Delete http:// hotel.co.il/Rooms



מיפוי Routes  של תאריכים:
שליפת רשימת כל תאריכים שקיימים במלון                  Get http:// hotel.co.il/Dates
שליפת תאריך על פי המס' מזהה שלו                 Get http:// hotel.co.il/ Dates /1 
הוספת תאריך                                    Post http:// hotel.co.il/ Dates   
עדכון תאריך                                     Put http:// hotel.co.il/ Dates 
שליפת רשימת תאריכים שתפוסים במלון                Delete http:// hotel.co.il/ Dates 

