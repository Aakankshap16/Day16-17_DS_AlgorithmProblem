using System.Text.RegularExpressions;
namespace BinarySearchTree
{
    public class RegexCustomMsgDemostration
    {
        public void Change()
        {
            // read in the message
            string message = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. Please, let us know in case of any clarification. Thank you BridgeLabz <<01/01/2016>>.";


            string nameRegex = "<<name>>";
            string name = "Aakanksha";  // replace with your first name
            message = Regex.Replace(message, nameRegex, name);


            string fullNameRegex = "<<full name>>";
            string fullName = "Aakanksha Pandey";  // replace with your full name
            message = Regex.Replace(message, fullNameRegex, fullName);


            string mobileRegex = @"91-\d{10}";
            string mobile = "91-8878243511";  // replace with your mobile number
            message = Regex.Replace(message, mobileRegex, mobile);

            // replace any date in the format XX/XX/XXXX by current date
            string dateRegex = @"\d{2}/\d{2}/\d{4}"; // \d use for any digit @ use before to rite string literal  
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
            message = Regex.Replace(message, dateRegex, currentDate);

            Console.WriteLine(message);
        }
    }
}





