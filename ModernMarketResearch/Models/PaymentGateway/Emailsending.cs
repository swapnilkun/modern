using ExcellentMarketResearch.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ExcellentMarketResearch.Models.PaymentGateway
{
    public class Emailsending
    {
        public bool SendEmail(string From, string DisplayName, string To, string CC, string Bcc, string Subject, string MailBody)
        {

            MailMessage msg = new MailMessage();
            bool result = false;
            //sending Mail 
            try
            {
                msg.From = new MailAddress(From, DisplayName);
                //if (To != "") msg.To.Add(To);

                string[] strTo = To.Split(','); if (To != "" && strTo.Length > 0) { for (int count = 0; count < strTo.Length; count++)  msg.To.Add(strTo[count].Trim()); }
                string[] strCc = CC.Split(','); if (CC != "" && strCc.Length > 0) { for (int count = 0; count < strCc.Length; count++) msg.CC.Add(strCc[count].Trim()); }
                string[] strBcc = Bcc.Split(','); if (Bcc != "" && strBcc.Length > 0) { for (int count = 0; count < strBcc.Length; count++)msg.Bcc.Add(strBcc[count].Trim()); }
                msg.Priority = MailPriority.Normal;
                //msg.Subject = "Search_Radiology " + Subject;
                msg.Subject = Subject;
                msg.Body = MailBody;
                msg.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    // Host = "smtp.qygroup.biz",
                    //  Host = "smtp.gmail.com",
                    //  Port = 587,
                    Credentials = new NetworkCredential("balasahebpatil1612@gmail.com", "swami7758055664"),
                    EnableSsl = true
                    //DeliveryMethod = SmtpDeliveryMethod.Network,
                    // UseDefaultCredentials = false,



                };
                client.Send(msg);//uncomment while uploading
                result = true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                result = false;
            }
            finally
            {
                msg.Dispose();
            }
            return result;
        }


        public string GenerateMailBody_PaymentInitiated(string ReportTitle, string Name, string EmailID, string ContactNo, string NameOfCompany, string Address, string State, string CountryName, string ZipCode)
        {
            string result = "";
            result = "Dear Admin, </br> Payment for report <b> " + ReportTitle + " </b> <br/>"
                    + "<table> <tr><td> <b> Customer Name - </b> </td><td> " + Name + " </td></tr>"
                        + "<tr><td><b> Email Id -</b> </td><td>" + EmailID + "</td></tr>"
                        + "<tr><td><b> Phone -</b></td><td> " + ContactNo + " </td></tr>"
                        + "<tr><td><b> Name of company -</b></td><td> " + NameOfCompany + " </td></tr>"
                        + "<tr><td><b>Address</b></td><td>" + Address + "</td></tr>"
                        + "<tr><td><b>State</b></td><td>" + State + "</td></tr>"
                        + "<tr><td><b>Country Name -</b></td><td>" + CountryName + " </td></tr>"
                        + "<tr><td>Zip Code<b></b></td><td>" + ZipCode + "</td></tr>"
                        + "<tr><td><b>IP Address -</b> </td><td>" + ExcellentMarketResearch.Models.PaymentGateway.IPAddress.GetIPAddress() + "</td></tr>"
                    + "</table>";
            return result;
        }

        public string GenerateMailBody_PaymentInitiated_AutoReply(string ReportTitle, string Name)
        {
            string result = "";
            result = "Dear " + Name + ","
                + "<br/><br/>Thank you for your interest in our research report " + ReportTitle + "."
                + "<br />Let us know in any problem while payment."
                + "<br/><br/>Thanks";
            return result;
        }


        //public string GenerateMailBody_RequestSample(string PaymentSucess, BuyingVM userdata)
        //{
        //    string result = "";
        //    //result = "Dear Admin, Payment made for <br /><br />" + "<table>";
        //    result = PaymentSucess + "<table>";
        //    result += userdata.ReportTitle != "" ? "<tr> <td valign='top' width='30%'><b>Report Title</b></td>   <td valign='top' width='2%'><b> : </b></td> <td valign='top' width='68%'>" + userdata.ReportTitle + "</td> </tr>" : "";
        //    result += userdata.Name != "" ? "<tr> <td valign='top'><b>Customer Name</b></td>  <td valign='top'><b> : </b></td> <td valign='top'>" + userdata.Name + "</td> </tr>" : "";
        //    result += userdata.EmailId != "" ? "<tr> <td valign='top'><b>Email ID</b></td>       <td valign='top'><b> : </b></td> <td valign='top'>" + userdata.EmailId + "</td> </tr>" : "";
        //    result += userdata.PhoneNumber != "" ? "<tr> <td valign='top'><b>Phone</b></td>          <td valign='top'><b> : </b></td> <td valign='top'>" + userdata.PhoneNumber + "</td> </tr>" : "";
        //    result += userdata.Company != "" ? "<tr> <td valign='top'><b>Company Name</b></td>   <td valign='top'><b> : </b></td> <td valign='top'>" + userdata.Company + "</td> </tr>" : "";
        //    result += userdata.Designation != "" ? "<tr> <td valign='top'><b>Designation</b></td>    <td valign='top'><b> : </b></td> <td valign='top'>" + userdata.Designation + "</td> </tr>" : "";
        //    result += userdata.Country != "" ? "<tr> <td valign='top'><b>Country Name</b></td>   <td valign='top'><b> : </b></td> <td valign='top'>" + userdata.Country + "</td> </tr>" : "";
        //    //result += txtComment.Text.Trim() != "" ? "<tr> <td valign='top'><b>Enquiry Text</b></td>   <td valign='top'><b> : </b></td> <td valign='top'>" + txtComment.Text.Trim() + "</td> </tr>" : "";
        //    result += "<tr> <td valign='top'><b>IP Address</b></td>     <td valign='top'><b> : </b></td> <td valign='top'>" + userdata.IPAddress + "</td> </tr>";
        //    result += "</table>";
        //    return result;
        //}

        public string GenerateMailBody_RequestSample_AutoReply(string Name, string ReportTitle)
        {
            string result = "";
            result = "Dear " + Name + ","
                + "<br /><br />Thanks for payment for report, <b>" + ReportTitle + "</b>."
                + "<br /><br />Hope you like our service. We would like to service you again."
                + "<br /><br />Thanks,"
                + "<br />" + "www.excellentmarketresearch.com" + " | " + "www.excellentmarketresearch.com";
            return result;
        }

        public string GenerateMailBody_PaypalError_AutoReply(string Name, string ReportTitle, string ReportURL)
        {
            string result = "";
            result = "Dear " + Name + ","
                + "<br /><br />You canceled payment for report,"
                + "<br /><b>" + ReportTitle + "</b>."
                + "<br />" + "www.QYGROUP.biz" + "/report/" + ReportURL
                + "<br /><br />Did you experienced problem in our service?"
                + "<br /><br />Let us know."
                + "<b><br /><br />Warm regards,"
                + "<br />Joel John | Corporate Sales Specialist,USA"
                + "<br />Direct line: + 1-855-465-4651"
                + "<br />9D Research Group"
                + "<br />E-mail: joel@9dresearchgroup.com | Web: " + "www.QYGROUP.biz" + "</b>"
                + "<br /><br />Thanks,"
                + "<br />9D Research Group";
            return result;
        }
    }
}