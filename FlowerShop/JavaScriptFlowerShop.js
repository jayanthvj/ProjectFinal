function cardnumbervalidation()
{ 
    var regex = /^(?:4[0-9]{12}(?:[0-9]{3})?)$/;
    var num=document.getElementById("cardNumber").value;
    var data=regex.test(num);
    if (!data) {
        alert("Card number is invalid!");
       
        }
}
function validateSecurityCode() {
    var ccv = document.getElementById("securityNumber").value;
    var regex = /^[0-9]{3}$/;
    var securitynum = regex.test(ccv);
    if(!securitynum)
    {
        
        alert("enter the correct CCV");
    }
}
function ExpirydatemonthValidation() {
    var month = document.getElementById("months").value;
    if (month === null ) {
        
        alert("Expiry Month is invalid!");
    }
}
function ExpirydateyearValidation() {
    var year = document.getElementById("year").value;
    if ( year === null) {
       
        alert("Expiry Month is invalid!");
    }
}
function CardholderNameValidation()
{
    var name = document.getElementById("cardHoldersName").value;
    var regex = /^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$/;
    var cardholdername = regex.test(name);
    if(!cardholdername)
    {
       
        alter("enter the correct format name");
    }
}
function Addressvalidation()
{
    var address = document.getElementById("Address1").value;
    if(address===null)
    {
        
        alert("fill the address");
    }
}
function Townvalidation() {
    var town = document.getElementById("City").value;
    var regex = /^[A-Za-z]+$/;
    if (!card===regex.test(town)) {
       
        alert("enter the Town/City");
    }
}
function RegionValidation() {
    var region = document.getElementById("Region");
    var regex = /^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$/;
    if (!regiondata===regex.test(region))
    {
      
        alert("Region is invalid!");
    } 
    
}
function Postalcodevalidation() {
    var postalcode = document.getElementById("pincode").value;
    var regex = /^(?:6[0-9]{6})$/;
    var code = regex.test(postalcode);
    if (!code) {
      
        alert("enter the Town/City");
    }
}
function Countryvalidation() {
    var country = document.getElementById("Country").selectedIndex;
    if (country === 0) alert("Country is invalid");
}
function telephonevalidation() {
    var telephone = document.getElementById("Telephone").value;
    var regex = /^\+?([6-9]{2})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$/;
    if(!telenum===regex.test(telephone))
    {
        alert("please insert valid number");
    }
}
function faxnumbervalidation(){
    var number = document.getElementById("Fax").value;
    var regex = /^\+?[0-9]{6,13}$/;
    if(!faxnum===regex.test(number))
    {
        alert("please enter the validate fax number");
    }
}
function emailvalidation() {
    var mail = document.getElementById("email").value;
    var regex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if(!maildata===regex.test(mail))
    {
        alert("please enter the validate emailID");
    }
}

function Payment() {
    var cardnumber = document.getElementById("cardnumber").value.length;
    var ccv = document.getElementById("securityNumber").value.length;
    var cardholdername = document.getElementById("cardHoldersName").value.length;
    var address = document.getElementById("Address1").value.length;
    var town = document.getElementById("City").value.length;
    var postalcode = document.getElementById("pincode").value.length;
    var email = document.getElementById("email").value.length;
    if (
      cardnumber > 0 &&
      ccv > 0 &&
      cardholdername > 0 &&
      address > 0 &&
      town > 0 &&
      postalcode > 0 &&
      email > 0
    ) {
        alert("Paymet Successfull!");
    }
    else {
        alert("Payment Unsuccessful");
    }
}
