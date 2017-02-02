using System;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Courier.Core;
using Umbraco.Courier.Core.Extraction;
using Umbraco.Courier.Core.Notifier;

namespace UmbracoCourier.EventsLogger
{
    public class RegisterEvents : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            ExtractionManagerEvents.Extracted += ExtractionManagerEvents_Extracted;
            ExtractionManagerEvents.ExtractedItem += ExtractionManagerEvents_ExtractedItem;
            ExtractionManagerEvents.ExtractedItemResources += ExtractionManagerEvents_ExtractedItemResources;
            ExtractionManagerEvents.Extracting += ExtractionManagerEvents_Extracting;
            ExtractionManagerEvents.ExtractingItem += ExtractionManagerEvents_ExtractingItem;
            ExtractionManagerEvents.ExtractingItemResources += ExtractionManagerEvents_ExtractingItemResources;
            ExtractionManagerEvents.PostProcessed += ExtractionManagerEvents_PostProcessed;
            ExtractionManagerEvents.PostProcessedItem += ExtractionManagerEvents_PostProcessedItem;
            ExtractionManagerEvents.PostProcessing += ExtractionManagerEvents_PostProcessing;
            ExtractionManagerEvents.PostProcessingItem += ExtractionManagerEvents_PostProcessingItem;
        }

        private void ExtractionManagerEvents_Extracted(object sender, ExtractionEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_Extracted");
        }

        private void ExtractionManagerEvents_ExtractedItem(object sender, ItemEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_ExtractedItem");
        }

        private void ExtractionManagerEvents_ExtractedItemResources(object sender, ItemEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_ExtractedItemResources");
        }

        private void ExtractionManagerEvents_Extracting(object sender, ExtractionEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_Extracting");
        }

        private void ExtractionManagerEvents_ExtractingItem(object sender, ItemEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_ExtractingItem");
        }

        private void ExtractionManagerEvents_ExtractingItemResources(object sender, ItemEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_ExtractingItemResources");
        }

        private void ExtractionManagerEvents_PostProcessed(object sender, ExtractionEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_PostProcessed");
        }

        private void ExtractionManagerEvents_PostProcessedItem(object sender, ItemEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_PostProcessedItem");
        }

        private void ExtractionManagerEvents_PostProcessing(object sender, ExtractionEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_PostProcessing");
        }

        private void ExtractionManagerEvents_PostProcessingItem(object sender, ItemEventArgs e)
        {
            LogEvent(sender, e, "ExtractionManagerEvents_PostProcessingItem");
        }

        private void LogEvent(object sender, ItemEventArgs e, string eventName)
        {
            LogEvent(sender, eventName);
            if (e == null)
            {
                LogHelper.Info<RegisterEvents>(eventName + ": ItemEventArgs is null.");
            }
            else
            {
                if (e.Item == null)
                {
                    LogHelper.Info<RegisterEvents>(eventName + ": ItemEventArgs.Item is null.");
                }
                else
                {
                    if (e.Item.ItemId == null)
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": ItemEventArgs.Item.ItemId is null.");
                    }
                    else
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": ItemEventArgs.Item.ItemId: " + e.Item.ItemId.ToString());
                    }
                    LogHelper.Info<RegisterEvents>(eventName + ": ItemEventArgs.Item.ItemType: " + e.Item.ItemType.ToString());
                    if (e.Item.Name == null)
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": ItemEventArgs.Item.Name is null.");
                    }
                    else
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": ItemEventArgs.Item.Name: " + e.Item.Name);
                    }
                }
                if (e.ItemId == null)
                {
                    LogHelper.Info<RegisterEvents>(eventName + ": ItemEventArgs.ItemId is null.");
                }
                else
                {
                    LogHelper.Info<RegisterEvents>(eventName + ": ItemEventArgs.ItemId: " + e.ItemId.ToString());
                }
            }
        }

        private void LogEvent(object sender, ExtractionEventArgs e, string eventName)
        {
            LogEvent(sender, eventName);
        }

        private void LogEvent(object sender, string eventName)
        {
            LogHelper.Info<RegisterEvents>(eventName);
            try
            {
                RevisionExtraction re = (RevisionExtraction)sender;
                LogHelper.Info<RegisterEvents>(eventName + ": sender parameter is an RevisionExtraction object.");
                if (re.Revision == null)
                {
                    LogHelper.Info<RegisterEvents>(eventName + ": ExecutionContext is null.");
                }
                else
                {
                    
                }
                if (re.Context == null)
                {
                    LogHelper.Info<RegisterEvents>(eventName + ": ExecutionContext is null.");
                }
                if (re.CurrentItem == null)
                {
                    LogHelper.Info<RegisterEvents>(eventName + ": CurrentItem is null.");
                }
                else
                {
                    if (re.CurrentItem.ItemId == null)
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": CurrentItem.ItemId is null.");
                    }
                    else
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": CurrentItem.ItemId.Id: " + re.CurrentItem.ItemId.Id);
                    }
                    LogHelper.Info<RegisterEvents>(eventName + ": CurrentItem.ItemType: " + re.CurrentItem.ItemType.ToString());
                    if (re.CurrentItem.Name == null)
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": CurrentItem.Name is null.");
                    }
                    else
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": CurrentItem.Name: " + re.CurrentItem.Name);
                    }
                }
                if (re.CurrentPostProcessingItem == null)
                {
                    LogHelper.Info<RegisterEvents>(eventName + ": CurrentPostProcessingItem is null.");
                }
                else
                {
                    if (re.CurrentPostProcessingItem.ItemId == null)
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": CurrentPostProcessingItem.ItemId is null.");
                    }
                    else
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": CurrentPostProcessingItem.ItemId.Id: " + re.CurrentPostProcessingItem.ItemId.Id);
                    }
                    LogHelper.Info<RegisterEvents>(eventName + ": CurrentPostProcessingItem.ItemType: " + re.CurrentPostProcessingItem.ItemType.ToString());
                    if (re.CurrentItem.Name == null)
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": CurrentPostProcessingItem.Name is null.");
                    }
                    else
                    {
                        LogHelper.Info<RegisterEvents>(eventName + ": CurrentPostProcessingItem.Name: " + re.CurrentPostProcessingItem.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error<RegisterEvents>("event: " + eventName, ex);
            }
        }

    }
}
