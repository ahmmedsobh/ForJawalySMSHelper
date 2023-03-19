<h1>Description</h1>
<p>send SMS messages to one or more phone numbers with 4jawaly API by API secret , API key and sender name </p>
<h3>you can use this package in :</h3>
<ul>
<li>windows apps (windows forms etc)</li>
<li>web apps (asp.net, asp.net core)</li>
<li>mobile apps (xamarin forms , dot net MAUI)</li>
</ul>

<h2> how to use package</p2>
<h6>1. install package in your project</h6>
you can install package from nuget packages : 

<h6>2. Send messages as shown in the code</h6>
 <code>
 ForJawalySMS.app_key = "your app key";
ForJawalySMS.app_secret = "your app secret";
ForJawalySMS.sender = "your sender name";
var numbers = new List<string>() { "XXXXXXXXXXX","XXXXXXXXX" };
  Root root = new Root()
  {
      text = "type message here",
      numbers = numbers
  };
_4jawalyRoot result = await ForJawalySMS.SendSms(root);
</code>




