#pragma checksum "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c97f6f16ff3f5f9a877133f0db1e985c7d05a0a"
// <auto-generated/>
#pragma warning disable 1591
namespace Interval_Training.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using Interval_Training;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using Interval_Training.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lione\Desktop\Side Projects\Interval_Training\_Imports.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 3 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
     CurrentPhaseTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 5 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
 if (phase < 3)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "StepsAndRepsContainer");
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 10 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
         for (int i = 0; i < @CurrentPhaseSteps.Count; i++)
        {

            int iCopy = i; // https://stackoverflow.com/questions/56425558/blazor-variable-argument-passing-to-onclick-function/56426146#56426146

            if (i != 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "rep");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.AddMarkupContent(11, "<p>X </p>\r\n                    ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "number");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 19 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                                                 CurrentPhaseStepReps[i - 1].reps

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                                                                                                e => CurrentPhaseStepReps[iCopy - 1].reps = int.Parse(e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 21 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
            }


#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "step");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "stepTime");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "class", "inp");
            __builder.AddAttribute(27, "type", "number");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 25 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                                                             CurrentPhaseSteps[i].CurrentMinutes

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                                                                                                               e => CurrentPhaseSteps[iCopy].CurrentMinutes = int.Parse(e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.AddMarkupContent(31, "<p> min</p>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "stepSpeed");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "class", "inp");
            __builder.AddAttribute(38, "type", "number");
            __builder.AddAttribute(39, "value", 
#nullable restore
#line 29 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                                                             CurrentPhaseSteps[i].CurrentSpeed

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                                                                                                             e => CurrentPhaseSteps[iCopy].CurrentSpeed = int.Parse(e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.AddMarkupContent(42, "<p> km/h</p>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 33 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.AddContent(47, "    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "phaseInfos");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<p><strong>Current phase : </strong> </p>\r\n        ");
            __builder.OpenElement(52, "p");
            __builder.AddContent(53, 
#nullable restore
#line 38 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
            CurrentPhaseTime.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, " minutes");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "p");
            __builder.AddContent(57, 
#nullable restore
#line 39 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
            Math.Round(CurrentPhaseDistance, 2).ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, " kms");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.AddContent(61, "    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "phaseInfos");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.AddMarkupContent(65, "<p><strong>Total : </strong> </p>\r\n        ");
            __builder.OpenElement(66, "p");
            __builder.AddContent(67, 
#nullable restore
#line 44 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
            TotalTime.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(68, " minutes");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenElement(70, "p");
            __builder.AddContent(71, 
#nullable restore
#line 45 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
            Math.Round(TotalDistance, 2).ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(72, " kms ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
            __builder.AddContent(75, "    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "buttons");
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                          PreviousPhase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(81, "Previous Phase");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                          AddStep

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, "Add Step");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.OpenElement(87, "button");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                          NextPhase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Next Phase");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 53 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"

}

else if (phase == 3)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "timer");
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "currentStep");
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.OpenElement(99, "p");
            __builder.AddContent(100, 
#nullable restore
#line 61 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                CurrentStepTimerDisplayString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "p");
            __builder.AddContent(103, 
#nullable restore
#line 62 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                CurrentStepSpeed

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(104, " km/h");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n        \r\n        ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "nextStep");
            __builder.AddMarkupContent(109, "\r\n            ");
            __builder.OpenElement(110, "p");
            __builder.AddContent(111, 
#nullable restore
#line 66 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                NextStepTimerDisplayString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.OpenElement(113, "p");
            __builder.AddContent(114, 
#nullable restore
#line 67 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                NextStepSpeed

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(115, " km/h");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
            __builder.AddContent(119, "    ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "buttons");
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.OpenElement(123, "button");
            __builder.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                          PreviousPhase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(125, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n        ");
            __builder.OpenElement(127, "button");
            __builder.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                          StartStop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(129, 
#nullable restore
#line 74 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                                       aTimer.Enabled ? "Stop" : "Start"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n        ");
            __builder.OpenElement(131, "button");
            __builder.AddAttribute(132, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                          ResetTimer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(133, "Reset");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n");
#nullable restore
#line 77 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
}

else if (phase == 4)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(136, "    ");
            __builder.OpenElement(137, "button");
            __builder.AddAttribute(138, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
                      PreviousPhase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(139, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 82 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\lione\Desktop\Side Projects\Interval_Training\Pages\Index.razor"
       

    // All infos needed for displaying timer 
    int CurrentStepIndex = -1;
    int CurrentStepSeconds;
    int CurrentStepSpeed;
    int NextStepSeconds;
    int NextStepSpeed;
    string CurrentStepTimerDisplayString
    {
        get
        {
            TimeSpan time = TimeSpan.FromSeconds(CurrentStepSeconds);

            //here backslash is must to tell that colon is
            //not the part of format, it just a character that we want in output
            return time.ToString(@"mm\:ss");
        }
    }
    string NextStepTimerDisplayString
    {
        get
        {
            TimeSpan time = TimeSpan.FromSeconds(NextStepSeconds);

            //here backslash is must to tell that colon is
            //not the part of format, it just a character that we want in output
            return time.ToString(@"mm\:ss");
        }
    }

    int phase = 0; // 0 warmup - 1 training - 2 cooling - 3 IN PROGRESS - 4 Training complete
    string CurrentPhaseTitle
    {
        get
        {
            switch (phase)
            {
                case 0:
                    return "Warmup steps";
                case 1:
                    return "Training steps";
                case 2:
                    return "Cooling steps";
                case 3:
                    return "Training";
                case 4:
                    return "It's over. Well done.";
                default:
                    return "";
            }
        }
    }

    int TotalTime
    {
        get
        {
            return WarmupTime + TrainingTime + CoolingTime;
        }
    }
    Double TotalDistance
    {
        get
        {
            return WarmupDistance + TrainingDistance + CoolingDistance;
        }
    }
    List<Step> AllSteps
    {
        get
        {
            List<Step> warmupSteps = new List<Step>();
            List<Step> trainingSteps = new List<Step>();
            List<Step> coolingSteps = new List<Step>();
            List<Step> allSteps = new List<Step>();

            allSteps.Add(WarmupSteps[0]);

            for (int i = 1; i < WarmupSteps.Count; i++)
            {
                int currentCounter = WarmupStepReps[i - 1].reps;
                while (currentCounter != 0)
                {
                    allSteps.Add(WarmupSteps[i]);
                    currentCounter--;

                    if (currentCounter != 0)
                    {
                        allSteps.Add(WarmupSteps[i - 1]);
                    }
                }
            } // add all warmup steps

            allSteps.Add(TrainingSteps[0]);

            for (int i = 1; i < TrainingSteps.Count; i++)
            {
                int currentCounter = TrainingStepReps[i - 1].reps;
                while (currentCounter != 0)
                {
                    allSteps.Add(TrainingSteps[i]);
                    currentCounter--;

                    if (currentCounter != 0)
                    {
                        allSteps.Add(TrainingSteps[i - 1]);
                    }
                }
            } // add all training steps

            allSteps.Add(CoolingSteps[0]);

            for (int i = 1; i < CoolingSteps.Count; i++)
            {
                int currentCounter = CoolingStepReps[i - 1].reps;
                while (currentCounter != 0)
                {
                    allSteps.Add(CoolingSteps[i]);
                    currentCounter--;

                    if (currentCounter != 0)
                    {
                        allSteps.Add(CoolingSteps[i - 1]);
                    }
                }
            } // add all cooling steps

            return allSteps;

        }
    }

    List<Step> WarmupSteps = new List<Step>() { new Step() };
    List<StepRep> WarmupStepReps = new List<StepRep>() { };
    int WarmupTime
    {
        get
        {


            if (WarmupSteps.Count == 1 || WarmupStepReps.Count == 0)
            {
                return WarmupSteps[0].CurrentMinutes;
            }

            int total = WarmupSteps[0].CurrentMinutes * WarmupStepReps[0].reps;

            for (int i = 1; i < WarmupSteps.Count; i++)
            {
                total += WarmupSteps[i].CurrentMinutes * WarmupStepReps[i - 1].reps;
            }
            return total;

        }
    }
    Double WarmupDistance
    {
        get
        {
            if (WarmupSteps.Count == 1 || WarmupStepReps.Count == 0)
            {
                return ((double)WarmupSteps[0].CurrentSpeed / 60.0) * WarmupSteps[0].CurrentMinutes;
            }

            Double total = (double)((double)(WarmupSteps[0].CurrentSpeed / 60.0) * (double)WarmupSteps[0].CurrentMinutes) * (double)WarmupStepReps[0].reps;

            for (int i = 1; i < WarmupSteps.Count; i++)
            {
                total += (double)((double)(WarmupSteps[i].CurrentSpeed / 60.0) * (double)WarmupSteps[i].CurrentMinutes) * (double)WarmupStepReps[i - 1].reps;
            }
            return total;
        }
    }

    List<Step> TrainingSteps = new List<Step>() { new Step() };
    List<StepRep> TrainingStepReps = new List<StepRep>() { };
    int TrainingTime
    {
        get
        {
            if (TrainingSteps.Count == 1 || TrainingStepReps.Count == 0)
            {
                return TrainingSteps[0].CurrentMinutes;
            }

            int total = TrainingSteps[0].CurrentMinutes * TrainingStepReps[0].reps;

            for (int i = 1; i < TrainingSteps.Count; i++)
            {
                total += TrainingSteps[i].CurrentMinutes * TrainingStepReps[i - 1].reps;
            }
            return total;
        }
    }
    Double TrainingDistance
    {
        get
        {
            if (TrainingSteps.Count == 1 || TrainingStepReps.Count == 0)
            {
                return ((double)TrainingSteps[0].CurrentSpeed / 60.0) * TrainingSteps[0].CurrentMinutes;
            }

            Double total = (double)((double)(TrainingSteps[0].CurrentSpeed / 60.0) * (double)TrainingSteps[0].CurrentMinutes) * (double)TrainingStepReps[0].reps;

            for (int i = 1; i < TrainingSteps.Count; i++)
            {
                total += (double)((double)(TrainingSteps[i].CurrentSpeed / 60.0) * (double)TrainingSteps[i].CurrentMinutes) * (double)TrainingStepReps[i - 1].reps;
            }
            return total;
        }
    }

    List<Step> CoolingSteps = new List<Step>() { new Step() };
    List<StepRep> CoolingStepReps = new List<StepRep>() { };
    int CoolingTime
    {
        get
        {
            if (CoolingSteps.Count == 1 || CoolingStepReps.Count == 0)
            {
                return CoolingSteps[0].CurrentMinutes;
            }

            int total = CoolingSteps[0].CurrentMinutes * CoolingStepReps[0].reps;

            for (int i = 1; i < CoolingSteps.Count; i++)
            {
                total += CoolingSteps[i].CurrentMinutes * CoolingStepReps[i - 1].reps;
            }
            return total;
        }
    }
    Double CoolingDistance
    {
        get
        {
            if (CoolingSteps.Count == 1 || CoolingStepReps.Count == 0)
            {
                return ((double)CoolingSteps[0].CurrentSpeed / 60.0) * CoolingSteps[0].CurrentMinutes;
            }

            Double total = (double)((double)(CoolingSteps[0].CurrentSpeed / 60.0) * (double)CoolingSteps[0].CurrentMinutes) * (double)CoolingStepReps[0].reps;

            for (int i = 1; i < CoolingSteps.Count; i++)
            {
                total += (double)((double)(CoolingSteps[i].CurrentSpeed / 60.0) * (double)CoolingSteps[i].CurrentMinutes) * (double)CoolingStepReps[i - 1].reps;
            }
            return total;
        }
    }

    List<Step> CurrentPhaseSteps
    {
        get
        {
            switch (phase)
            {
                case 0:
                    return WarmupSteps;
                case 1:
                    return TrainingSteps;
                case 2:
                    return CoolingSteps;
                default:
                    return WarmupSteps;
            }
        }
    }
    List<StepRep> CurrentPhaseStepReps
    {
        get
        {
            switch (phase)
            {
                case 0:
                    return WarmupStepReps;
                case 1:
                    return TrainingStepReps;
                case 2:
                    return CoolingStepReps;
                default:
                    return WarmupStepReps;
            }
        }
    }
    int CurrentPhaseTime
    {
        get
        {
            switch (phase)
            {
                case 0:
                    return WarmupTime;
                case 1:
                    return TrainingTime;
                case 2:
                    return CoolingTime;
                default:
                    return WarmupTime;
            }
        }
    }
    Double CurrentPhaseDistance
    {
        get
        {
            switch (phase)
            {
                case 0:
                    return WarmupDistance;
                case 1:
                    return TrainingDistance;
                case 2:
                    return CoolingDistance;
                default:
                    return WarmupDistance;
            }
        }
    }

    private void AddStep()
    {

        switch (phase)
        {
            case 0:
                WarmupSteps.Add(new Step());
                WarmupStepReps.Add(new StepRep());
                break;
            case 1:
                TrainingSteps.Add(new Step());
                TrainingStepReps.Add(new StepRep());
                break;
            case 2:
                CoolingSteps.Add(new Step());
                CoolingStepReps.Add(new StepRep());
                break;
            default:
                break;
        }

    }
    private void PreviousPhase()
    {
        if (phase != 0)
        {
            phase--;
        }
    }
    private void NextPhase()
    {
        if (phase != 4)
        {
            phase++;
        }
    }

    // Timer creation, initialization and updates
    System.Timers.Timer aTimer = new System.Timers.Timer();
    protected override void OnInitialized()
    {
        aTimer.Elapsed += new ElapsedEventHandler(UpdateTimer);
        aTimer.Interval = 1000;

    }
    bool TimerIsOver = false;
    private void StartStop()
    {

        if (TimerIsOver)
        {
            TimerIsOver = false;
            ResetTimer();
            aTimer.Enabled = true;
            this.StateHasChanged();
        }
        else
        {
            aTimer.Enabled = !aTimer.Enabled;
            this.StateHasChanged();
        }

    }
    private void ResetTimer()
    {
        CurrentStepIndex = 0;
        CurrentStepSeconds = AllSteps[0].CurrentMinutes * 60;
        CurrentStepSpeed = AllSteps[0].CurrentSpeed;

        NextStepSeconds = AllSteps[1].CurrentMinutes * 60;
        NextStepSpeed = AllSteps[1].CurrentSpeed;
    }
    private void UpdateTimer(object source, ElapsedEventArgs e)
    {
        if (CurrentStepIndex == -1) // initialize
        {
            ResetTimer();
        }

        else
        {
            if (CurrentStepSeconds == 0)
            {

                if (CurrentStepIndex == AllSteps.Count - 1)
                {
                    TimerIsOver = true;
                    phase++;
                    aTimer.Enabled = !aTimer.Enabled;
                    this.StateHasChanged();

                } else
                {
                    CurrentStepIndex++;
                    CurrentStepSeconds = AllSteps[CurrentStepIndex].CurrentMinutes * 60;
                    CurrentStepSpeed = AllSteps[CurrentStepIndex].CurrentSpeed;

                    NextStepSeconds = AllSteps[CurrentStepIndex + 1].CurrentMinutes * 60;
                    NextStepSpeed = AllSteps[CurrentStepIndex + 1].CurrentSpeed;
                }


            }

            else
            {
                CurrentStepSeconds--;
            }
        }

        this.StateHasChanged();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
