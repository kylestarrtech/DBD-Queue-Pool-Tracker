# Dead by Daylight Queue Pool Tracker

## Summary
The **Dead by Daylight Queue Pool Tracker** is a tool used to track the general queue pools for both survivor and killer, alongside estimated times to find a match in any region - either individual or all at once!

### Disclaimer:
**This <ins>does not</ins> represent the total # of players - just those waiting for a game. The numbers do not show any significant impacts of stuff like gameplay changes, and shouldn't be used as "proof" that the game is dying or whatever. This is purely analytical data sent from Dead by Daylight's backend and should be used to compare the number of players based on time of day and stuff such as that.**

**Additionally, <ins>the risk of being banned from Dead by Daylight is very real with this program</ins>, it requires the use of Fiddler and also works by pretending the user connected to the BHVR session is queueing. As such, you cannot play Dead by Daylight while collecting data (unless the game is on a different platform not connected to your BHVR Account (cross-progression)**.

**<ins>Do NOT use this program if you have a fear of potentially being banned. You have been warned.</ins>**

## Overview

This tracker consists of a couple parts - it is mainly divided by statistics stuff on the right, and settings on the left (aside from the data table).

On the left, you'll find from top to bottom the status box (appropriately called the live output box), this basically just outputs the extracted data from the most recent queue data received from the backend. It's a way to keep you informed on the most recent requests made. It also displays the system time the request was made so it's a great way to determine if an issue has occurred (though several checks exist to make sure the program does not crash if BHVR sends something other than queue data). Additionally, if any problems occur with the program - they *should* display there.

The next item you'll find is the data collection interval - this basically is just how often - once you begin recording values - that the program will dip back into BHVR's backend. Super simple.

Next up, and probably the most complex setting with the most setup - the BHVR session. This requires the use of a program called **Fiddler**, which is an HTTPS sniffing tool that is capable of reading the requests your game client sends to Dead by Daylight's backend - included in that is your BHVR session. I'd love to make this process automatic in the future - but for now you'll need to get this when you collect matchmaking data. **You may need to use an SSL bypass to use this depending on your platform - be aware of that**.

The option after this is the region - this is basically the region you'd like to sample the queue pool data from - this basically works via artifically making the latency of the selected region 50, and the rest of the regions a random value between 150 and 250. Thus singling out the selected region as the *only one* suitable for a good match, thus fooling Dead by Daylight's matchmaking system into only giving data from that region.

Next up is simply your platform of choice. Since this is only usable on PC the two options are "steam" and "egs" - with "steam" obviously being Steam and "egs" being Epic Games Store.

The next ones are checkboxes. To be specific "Sniff All Regions" is just the toggle to remove the region selection and collect data from all regions.

When you collect data by sniffing all regions - it sums up the pools from all regions and averages the estimated wait times across all regions and saves them in a global region CSV file. Additionally, whenever it exams an individual region to sum it, it saves that individual regions data to its associated CSV file - sniffing all regions is a fantastic way to grab both summed and individual region data all at the same time!

The penultimate setting is whether or not Crossplay is enabled or not - this one is incredibly self-explanatory. But it also sometimes doesn't work.

Finally, the role to queue as - this will affect your estimated queue times only but is a good setting to utilize. Feel free to swap it on demand and observe the differences! It's interesting to observe!

Next up you'll see the data table, which shows a table with the exact numbers from the most recent data collected from Dead by Daylight's backend. Alongside this I might as well bring up the line graphs that basically sum up to three graphs for killer pool, survivor pool, and the estimated wait time that show the 100 most recent data entries.

Finally is just the button to begin recording those values! Simple functionality, just toggles on the recording of the data and ultimately puts the entire program into motion. It will first validate that everything is in line with the program to begin sending requests. If you see a constant error that shows - try replacing the BHVR Session ID and make sure it **doesn't** include the "bhvrSession=" bit.

## File Locations

You'll find all of the data for the program located in (Copy/Paste into Win+R menu):
%localappdata%\DBDMatchmakingLogger

Feel free to extract the data from there - if you want to clear all the data there's a clear button in the menu bar labelled "Clear", and a quick-launch button for the folder on the menu bar as well labelled "View Folder Data".

## Quick Setup Guide
The main bit of setup is using **Fiddler** to get your BHVR session ID. So here's a quick step-by-step guide:

1. Download **Fiddler** via https://www.telerik.com/download/fiddler
2. Open **Fiddler**
3. Make sure **Fiddler** is checking HTTPS traffic, there will be a certificate you need to download for this - normally it'll show up as a pop-up on first launch, otherwise it's located in one of the settings in the menu bar.
4. Launch Dead by Daylight
5. Try to log in
    5a. If you can't log in and it gives an SSL error, you'll require an SSL bypass or alternatively you'll have to use the Epic Games Store if you're getting the error on Steam.
6. Open survivor (or killer), queue then unqueue instantly.
7. Search in Fiddler's connection list (on the left) for the URL https://brill.live.bhvrdbd.com/api/v1/queue
8. Once you find it and click on it, on the right side of Fiddler navigate to the "Inspectors" tab. The tab selected underneath should be "Headers" - if not navigate to it on the top half of the Inspectors panel.
9. Locate under that the specific request header "bhvrSession=a1b2c3d4...".
10. Right click that and hit "Copy Value Only"
11. Paste the value in the "BHVR Session" area of the Queue Pool Tracker and make sure that the "bhvrSession=" bit is removed.
12. Next, select the platform you used in the Queue Pool Tracker to get the BHVR Session (Steam or Epic Games Store).
13. Done! You should be good to record values, the process seems complex but you can do this within a minute or two. If you get errors please double check the "bhvrSession=" bit at the start is removed and that the platform is properly selected. If you get errors after that get a new BHVR Session via the same method described in the steps above.

**Note:** BHVR Session IDs may expire within 24 hours. When tracking for a long period of time you might not be able to record data past a certain point due to this limitation.

## Support

Please DM or tweet me @SHADERSOP for support. I will be ignoring every other communication attempt made on any other method of communication regarding the topic.

Additionally, common questions will be incorporated into a FAQ on this readme.
