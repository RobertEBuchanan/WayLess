# WayLess
Wayless is intended to be a tool (or set of tools) to help track and manage wieght and health issues.

## Motivation
Obviously there are plenty of "diet" apps on the market.

I plan to use Wayless as a practice/sample application.  A certain amount of gratuitous overengineering is intentional.  YAGNI doesn't really apply, since this is a practice exercise.

## Functionality 
The basic application(s) should allow for easy tracking of inputs, outputs, results, goals, and genreal notes.
* Inputs include food, drink, sleep, and perhaps medications.
* Outputs are pretty much limited to excercise
* Results include weight, BP, test results, inches, etc
* Goals might include weight loss over time, improved BP, or staying on a certain diet.
* General notes would be simple comments, observations or notes of significant events.

There should also be a certain amount of BI.
The stat/home screen might be a dashboard.
There could be simple reports showing long and short term trends.

Multiple clients might be nice.
Perhaps there could be a full featured website.
Mobile clients might just be limited to data entry.

Mobile cleint woudl need to work in both connected and disconnected senarios.
Ideally, data woould ultimately be stored in the cloud. (integration, eaze of hosting, scaling)


## Techncial Notes
* Client UIs
  * Web UI (MVC?)
  * Desktop Clients - perhaps WPF | Electron | ???
  * Tablet - Perhaps Xamarin
* Data 
  * Ultimately in the Cloud - Webservice??? Azure???
  * Local Caching for Tablet / Mobile
    * Sync silently w/ service or cloud when connected
 

