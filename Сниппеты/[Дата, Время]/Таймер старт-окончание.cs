// Initialize timeouts variable
int durationTimer = int.Parse(project.Variables["endTimer"].Value);
long startTimer;
long endTimer;

// Set timer
startTimer = DateTimeOffset.Now.ToUnixTimeSeconds();
endTimer = startTimer + durationTimer;

// Unix timestamp is seconds past epoch
DateTime dt = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
string endTimerString = dt.AddSeconds(endTimer).ToLocalTime().ToString();

// Debug log info
project.SendWarningToLog("", "Processing timer end: "+ endTimerString, debugLogValue);

// Return timer
project.Variables["endTimer"].Value = endTimer.ToString();

// // Initialize end timer value
// string endTimer = project.Variables["endTimer"].Value;

// // If timer is out
// if (DateTimeOffset.Now.ToUnixTimeSeconds() > endTimer)
// {
 // // What to do, if timer is out
// }