Miner Control
=============

Here is a quick list of features:
- Supports multiple services which provide an API for pricing and payout in Bitcoin (more may be added if they are compatible).
  - NiceHash & Westhash
  - <del>TradeMyBit</del>
  - <del>YAAMP</del>
  - Any pool using YAAMP's source and the EXACT same api, aka YAAMP clones
  - <del>WafflePool</del>
  - LTCRabbit
  - WePayBTC
  - <del>Hamsterpool</del>
- API call once per minute to each service to get the current prices.
- Manual configurations for last resort backup pool.
- Failover support when miner exits abnormally (such as when pool is down).
- Minimum time to mine on new algorithm to allow for spin up of the miner.
- Time before switch to new best algorithm to avoid flickering between algorithms with similar payout levels.
- Possible to dynamically increase the previous switchtime according to the profit difference.
- Only switch when another pool has a certain % more profit to offer. This improves payouts from pools with PPLNS rewards and the likes.
- Delay possible between each spin up.
- Launch miners with a specified cpu priority and affinity. Handy for cpuminers.
- Ignore outlier prices, either by setting a percentile or an iqr-multiplier (Tukey hedge, but defaults to average + IQR * 2.2 instead of * 1.5)
- Mine by average price over a set window time.
- Stop mining if a certain minimum price has been reached, can be set in fiat or BTC prices.
- Doubleclick a pool to manually ban it, until doubleclicked again or restart.
- Forced restart of miner after maximum amount of time to avoid stuck miners.
- Config parameter substitution for common values in miner configs.
- View output from multiple mining computers on one system with 'remote console'.
- Loads MinerControl2.conf if it's the 2nd MinerControl instance (if it exists at all), MinerControl3.conf for 3th instance, etc...

Legal disclaimer: This program is not created, supported, or endorsed by any of the mining pools or miner software makers.  It is my own creation and you use it at your own risk.

Display details:
- Actions
  - Auto - Put miner in automatic mode for switching between algorithms.
  - Stop - Stop running miner.
  - <i>Mod</i>
  - Reload - Reloads the .conf if changes have been made. Will resume the tasks it was doing.
- Times
  - Running - How much total mining time has happened since the application started.
  - Current - How long the current mining session has been running.
  - Switch - How long before a switch occurs once a new entry is more profitable.
  - Restart - How long until the current mining session is restarted if no more profitable entry happens first.
- Donation
  - Time Until - How long until donation mining will take place
  - Mining Time - How long donation mining will run for
- Currency
  - Exchange - Exchange rate from local currency to Bitcoin.
  - Balance - Sum balance of all services in local currency.
- Top grid columns
  - Service - Which service provider this entry is for.
  - Updated - When pricing for this service was last updated.
  - Balance - Balance reported by the service.
  - Running - Total time spent mining against this service.
- Bottom grid columns
  - Service - Which service provider this entry is for.
  - Algo - Algorithm used for calculating hashrate and power.
  - Hash Rt - Hash rate for this algorithm for this machine.
  - Price - How much this algorithm earns on this service in BTC/GH/Day.
  - Earn - How much in BTC/Day this machine will earn.
  - Fees - Fees taken from earnings.
  - Power - Power cost per day in BTC.
  - Net - Net earned from earnings (adjusted for weighting) minus fees and power.
  - Balance - Balance at provider for this algorithm (only supported on NiceHash, WestHash, and WafflePool).
  - Accept - Current accept rate (only supported on NiceHash, WestHash, YAAMP, and WafflePool).
  - Reject - Current reject rate (only supported on NiceHash, WestHash, and WafflePool).
  - Running - How long spent mining for this entry since application started.
  - Status - Current status of the entry (only shows when miner is running).
    - Running - Currently running entry.
	- Pending - Entry that will start once switch time has been met.
    - Dead - Miner exited abnormally and hasn't reached its dead time threshold yet.
	- <i>Mod</i>
	- Too low - Entry is below the minimum price.
	- Banned - Pool is manually banned.
    - Outlier - Entry has a spike in profitability, mostly not worth it to switch to because of its temporary nature. Can be ignored.
  - Action - Start an individual miner for testing (only shows when miner is stopped).

  
An up to date configuration file can be found here: https://raw.githubusercontent.com/KBomba/MinerControl-KBomba/master/MinerControl/MinerControl.conf

Legend:
- general - General configuration parameters
  - power - Rate per KW/hour in your currency units
  - exchange - Default Bitcoin price in your currency units for calculating power cost in Bitcoin (only used if unable to download exchange rate)
  - currencycode - Three letter currency code to use for exchange rate (must be available in this list)
  - mintime - Minimum time in minutes to mine on new algorithm before auto-switch is allowed
  - maxtime - Maximum time in minutes to mine an algorithm under auto mode before a restart occurs
  - switchtime - Time in minutes that the current algorithm has to no longer be the best before switching to a new one under auto mode
  - deadtime - Time in minutes before an entry will be tried again after it fails and is marked as dead
  - logerrors - Log errors in 'error.log' file any time an exception is caught in the controller
  - logactivity - Log miner start and stop events in 'activity.log'
  - gridsortmode - 0 = never sort price grid, 1 = sort when in auto mode, 2 = sort whenever prices update (default 1)
  - minerkillmode - 0 = kill single process, 1 = kill process tree (default 1)
  - traymode - 0 = don't minimize to tray, 1 = minimize to tray and hide miner after starting while minimized, 2 = minimize to tray and start miners hidden while minimized
  - donationpercentage - Percentage of time to spend doing donation mining to support development of Miner Control (default 2)
  - donationfrequency - How often, in minutes, to do donation mining (default 240, or 4 hours)
  - remotesend - Send console output to remote receiver (default false)
  - remotereceive - Receive console output from remote senders (default false)
  - <i>Mod</i>
  - dynamicswitching - True or false, when set to true, it will decrease "switchtime" the higher the best price over the current price gets (default false)
  - dynamicswitchpower, dynamicswitchpivot, dynamicswitchoffset - Variables for the dynamic switching formula (default 2, 1.05, none):
  
    Dynamic switchtime = ("switchtime" / ((best entry price / currently running price) ^ "dynamicswitchpower")) + "dynamicswitchingoffset"
    Where "dynamicswitchoffset" defaults to:  "switchtime" - ("switchtime" * (1/"dynamicswitchpivot") ^ "dynamicswitchpower)).
	
  - statwindow - Time in minutes to run statistics on, range now-statwindow -> now (default 60).
  - minebyaverage - True or false, will use the average price, calculated from the statwindow, to determine the best entry (default false)
  - ignoreoutliers - True or false, will ignore prices that are deemed outliers according to data from the statwindow and certain variables, is ignored when mining by average (default false)
  - iqrmultiplier - Will determine if an entry is an outlier if the price is more than average+(interquartile range * iqrmultiplier), is the preferred method (default 2.2)
  - outlierpercentage - Will determine if an entry is an outlier if the price is at the Xth index when all prices are sorted from low to high, is an old, popular but inefficient method, set iqrmultiplier to -1 if you really want to use this (default 0.99)
  - minprofit - The price of the best entry will be kept pending if its profit divided by the currently running profit, is less than the ratio set here. Can also be set per pool, highest value wins. Does nothing if not set.
  - minprice - Absolute price in BTC or your own fiat before it actually starts mining. Append with "BTC" if you want to use a BTC price, append nothing for your currency. Defaults to 0, if power usage and price are set correctly, it won't mine when profits are negative. 
  - delay - Time in seconds between a stop and a start of the miner. Rapid switching makes some miners crash, set a 5 (second) delay to fix this, does nothing if not set.
  - exittime - Time in minutes after which Miner Control will shut down completely. Anything lower than 1 minute is ignored, does nothing if not set.
- algorithms - List of supported algorithms
  - name - Name of supported algorithm (only listed names are currently supported)
  - display - What to display in the 'Algo' column in the prices grid
  - hashrate - Your hashrate in kHash/sec
  - power - Watts your GPU pulls when mining an algorithm
  - aparam1, aparam2, aparam3 - algorithm based substitution value for use in folder, command, and arguments
  - <i>Mod</i>
  - priority - CPU priority to give to your miners, defaults to "Normal", other possible values are "Idle", "BelowNormal", "AboveNormal", "High" & "RealTime".
  - affinity - Hex mask (like in start /affinity) to set the process affinity, you can use 1 for first core, 2 for second core, 4 for third core, etc
- nicehash - Config section for NiceHash, omit to not use this service
  - account - Bitcoin address to mine against
  - worker - worker ID
  - weight - multiplier to adjust price if you don't fully trust the reported numbers
  - sparam1, sparam2, sparam3 - service based substitution value for use in folder, command, and arguments
  - algo - algorithm name from algorithms section above
  - priceid - value pricing API will use to distinguish an algorithm
  - folder - Folder where mining app is located, blank if same as the NiceHash.exe file
  - command - Command to execute
  - arguments - Arguments to include with the command
  - usewindow - Run miner in separate window from controller (default false)
  - <i>Mod</i>
  - minprofit - The price of the best entry will be kept pending if its profit divided by the currently running profit, is less than the ratio set here. Will use the value at general settings if it's higher or the current running and best pool are the same. Does nothing if not set.
  - detectstratum - Nicehash/Westhash exclusive! True or false, will ping to the endpoints of Nicehash/Westhash datacenters to determine which one is preferable. Checks every 6 hour for the best service to use.
- yaampclones - Config section for YAAMP, omit to not use this service, use whatever name you want, but if the url-param is not used, make sure to name it like the URL
  - (settings are the same as nicehash, except for detectstratum)
  - pricemode - 0 = current estimate, 1 = 24hr estimate, 2 = 24hr actual
  - <i>Mod</i>
  - balancemode - 0 = all unpaid, 1= sold on markets but unpaid, 2 = all unsolds, 3 = all paid ever, 4 = all paid, sold and unconfirmed.
  - url - if you want to use a different name than the URL for your yaampclone is, use this param for the correct URL (not required)
- ltcrabbit - Config section for LTCRabbit, omit to not use this service
  - (settings are the same as nicehash, except for detectstratum)
  - apikey - your API key to use in gathering prices
- wepaybtc - Config section for WePayBTC, omit to not use this service
  - settings are the same as nicehash, except for detectstratum)
- manual - Config section for manual miners, omit to not use this service, possible to use "manual1", "manual2", etc for different manual entries
  - (settings are the same as nicehash, except for detectstratum)
  - price - price to use for calculating earnings
  - fee - percentage fee to deduct from price


Substitution identifiers for command, folder, and argument parameters:

    _ADDRESS_ - Substitutes the above address if specified
    _WORKER_ - Substitutes the above worker if specified
    _APARAM1_ - Substitutes the above aparam1 if specified
    _APARAM2_ - Substitutes the above aparam2 if specified
    _APARAM3_ - Substitutes the above aparam3 if specified
    _SPARAM1_ - Substitutes the above sparam1 if specified
    _SPARAM2_ - Substitutes the above sparam2 if specified
    _SPARAM3_ - Substitutes the above sparam3 if specified


Instructions:

    Download into a folder on your Windows computer
    Make sure .NET Framework  4.5 is installed
    Modify MinerControl.conf with the settings for your own mining applications
    Start MinerControl.exe
    Click "Start" for each miner to confirm it launches and does not require confirmation each time it is opened
    Click "Auto" to change over to auto selection mode
    Profit!!


Command line arguments:

    -a | --auto-start Start mining in automatic mode as soon as the application starts.
    -m | --minimize Minimize application on startup.
    -t | --minimize-to-tray Minimize to the tool tray and hide miner when minimize icon is clicked.  This option is obsolete and the config setting "traymode" should be used instead.  If "traymode" is set to "0" then this option will switch it to "2".


Q & A:

    Q: How can I start mining automatically when MinerControl starts? 
	A: Launch with "MinerControl.exe --auto-start".
	
    Q: Miner Control starts to display, freezes for a second, and then crashes.  What is happening? 
	A: Most likely there is an error in the config file. Miner Control is sensitive to the formatting of this file and will crash badly if there is an error.  Make sure your "key":"value" pairs are all correctly named and that any path backslashes are created as double-backslash ("\\").  Consider using a validator just as JSON Lint to verify your config file structure.
    
	Q: Will Miner Control work on Windows XP? 
	A: Not anymore since the switch to .NET 4.5. One can still use an older version of MC. 
	
    Q: What does donation mining do? 
	A: Donation mining will mine to the MinerControl author's address or account for a percentage of time.  Default setting is for 2% of the time over four hours which works out to just under five minutes spent donation mining every four hours.  If the percentage is set to 0 then no donation mining will occur.
