# PromoCodeApi

The following are the steps for running the project locally. You will require Visual Studio 2019 and SQL Server installed locally.
1. Clone or Download the Repo.
2. Build the Solution.
3. Open appsettings.json file in Promocode.Api project. 
4. Edit the ConnectionStrings by replacing the values for Server, User ID and Password.
5. Under Tools, open Package Manager Console and run the following commands. Please Ensure the selected Default project is: PromoCode.Repository
  i) add-migration Promocode_Release
  ii) update-database
6. At this point PromoCode Database should be created on your local. To insert some test data, open the file PromoCode.Api\Data\PromoCode_Data.sql and run in SQL Server to create some test data.
7. Run the project. It will open with swagger documentation on port 4000 http://localhost:4000/swagger/index.html

The project is a .Net Core API which has 3 endpoints. 
1. /User/Authenticate - For authentication of user 
2. /PromoCode/GetPromoCodes - Return a list of PromoCodes
3. /PromoCode/ActivateBonus - To activate bonus for the logged in User.

