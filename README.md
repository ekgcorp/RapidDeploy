# RapidDeploy
Deployment Status Tracking of Microsoft Dynamics AX POS Devices, plus additional tools.

#Introduction
TODO: 
1.  Simple to use interface to aid in Final Staging and Deployment steps of PC's (this steps are mostly related to providing accurate reports to %CUSTOMER% as each step in migration is completed)
2.  Follows MVVM Standards
3.  Based on [Template 10](https://github.com/Windows-XAML/Template10)
4.  Software will be run on POS, KDS, and Tablets running POS Software (Some functionallity is to simplify Microsoft Dynamics AX interaction on POS Devices)
5.  Project built to run in Enterprise Environment and will need to have some Brokered Windows Runtime components to accomplish non standard functionallity. 
6.  Initially designed to handle the Functionallity necessary for Staging, Deployment, and Management of All newly deployed devices on %CUSTOMER% network.
7.  Has reporting feature for management, and ability to export to XLS, and Print
8.  Tracks users who provide steps thruout the process
9.  Will use Dummy Data via JSON or XML, but ultimately data will be hosted on %CUSTOMER% SQL
10. Need to tie into Shipper's Tracking info so that local POS manager can see any shipments of hardware necessary to prepare for Migration
11. Need to incorporate BING Map Control to display all sites migration progress. (Green Pins once fully deployed, Red Pins if they have yet to be started, and Yellow Pins when Staging step is completed)

BLING:
1. Ability to scan bar code or QR codes possibly
2. Nice if Notifications can happen to users stored email, Cell via Text, of via APP if its installed on their PC (Not a POS Device, or not connected to AX)

#Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

#Build and Test


#Contribute
Contributions to Rapid Deploy tool are most welcome. Here is how you can contribute to EKGCORP 1st ever software project.


If you want to learn more about creating good readme files then refer the following [guidelines](https://www.visualstudio.com/en-us/docs/git/create-a-readme). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)

