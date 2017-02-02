# UmbracoCourier.EventsLogger

This code logs Umbraco Courier extraction events. I created this because I am trying to figure out how (or if) these events work.
The [documentation on Courier events](https://our.umbraco.org/documentation/Add-ons/UmbracoCourier/Developer/EventProviders)
seems to be incomplete or outdated.  There does not seem to be much info about it online - a couple posts on Our Umbraco 
([here](https://our.umbraco.org/documentation/Add-ons/UmbracoCourier/Developer/EventProviders) 
and [here](https://our.umbraco.org/forum/umbraco-pro/courier/68070-event-handler-on-target-site-after-couriering)) 
asking about it and a slightly more informative [thread](https://our.umbraco.org/forum/umbraco-pro/courier/75734-courier-2523-events) 
that helps a little.

What I want is an event that has a node identifier for the node that was transfered so that I can use with Umbraco APIs. 
(It would be okay if I couldn't actually use the Umbraco APIs at tha moement, as long as I can get the ID (either int  or guid).

I have added event handlers with logging for each event available with `ExtractionManagerEvents` 
but the only one that seems to get executed is `ExtractedItemResources`.  Furthermore, the Item Id that I can access, does not seem to 
be a node id but the name of Document Types with the spaces removed (for example, "VideosLandingPage" (I have Document Type named 
"Videos Landing Page"). 
