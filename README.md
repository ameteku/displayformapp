# DisplayFormApp
# Project was made in Visual Studio 2022



**Future Goals for Schedule Display App**:
- Improve readability of the schedule form. 
- Automate the pulling of data from the sharepoint calender
- Handle Data Cleaning
- nit: Improve general code structure

**Improve readability of the schedule form**

The form is currently readable. The text is a little hard to see as the schedule for the week( a lot of data) is displayed on a relatively small screen.

***Proposed Solutions***
1. Real time removal of outdated schedules: As the days of the week goes by, schedules of the day before becomes useless. We can remove from the screen, the outdated schedules( by day or hour) and keep the rest.
  - Pros:
    - this removes unnesecary information
    - Provides more space for the rest of the schedule to be magnified

  - Cons:
    - If removed by the hour, someone trying to check if a class was held in the past hour will not be able to.
  
2. Display schedule by day: The font size of the schedule is based on how many rows the form currently has. Reducing the number of rows by displaying the schedule per day(currently per week)  significantly reduces the number of rows.
 
  - Pro:
    - More space for bigger fonts

  - Con:
    - Someone trying to reference the schedule for a future day will not be able to.

3. Merge data repeated in multiple rows into one big text: Repeated data like lab names/numbers and course names that are adjacent to each other could be merged into one big row. 
  - Pros: 
    - Bigger text is more readable
    - Avoids repetition of the same data
  - Cons:
    - Increased complexity in how the form/schedule table is created
    - Table could become disuniform and confusing if merging is overdone.

4. Make the display vertical : Doing this gives more vertical space( may reduce the horizontal space ) and therefore more space to increase the font size.
  - Pros: 
    - Simple to do
  - Cons:
    - Can't really think of any


**Automate Pulling of Data from SharePoint Calender**

Currently, in order to update the application with new data, someone has to manually go through a long and repetitive process to pull the data from sharepoint before even uploading.

Microsoft has made an api available for interacting with thye calender data.  Using the API, we can create the option of the program automatically pulling the data periodically.

After some digging, the required steps needed to make this happen are:
1.  Register an application with microsoft [azure](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/users-default-permissions#to-restrict-the-default-permissions-for-member-users)
 This step needs a microsoft account. I tried using my sa account only to see that we have permissions for accessing api's turned of by default.
 A solution to this is just asking admin( Matt) fpr access for our SA accounts.
 Another solution is to create an account with permissions only to pull data from the API and register applications. 
 
2. Use the c# [sdk](https://github.com/microsoftgraph/msgraph-sdk-dotnet)
