using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace KontraktSMW.Workflow1
{
    public sealed partial class Workflow1
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition4 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition5 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition6 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition7 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition8 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition9 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition10 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition11 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition12 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken3 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken4 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken5 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken6 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken7 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken8 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            this.setStateActivity5 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity10 = new System.Workflow.Activities.SetStateActivity();
            this.StatusTelefon_Stracony = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity9 = new System.Workflow.Activities.SetStateActivity();
            this.StatusTelefon_Oferta = new System.Workflow.Activities.CodeActivity();
            this.logERROR_WefyfikacjaInit = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logERROR_WefyfikacjaEvent = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Stracony = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity4 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Telefon = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity3 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Oferta = new System.Workflow.Activities.CodeActivity();
            this.logERROR_NavigatorInit = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.Navigator_Stracony = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Uruchomienie = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Umowa = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Wniosek = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Oferta = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Telemarketing = new System.Workflow.Activities.SetStateActivity();
            this.Oferta_AkceptacjaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.Telemarketing_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Telemarketing_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity4 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity5 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlersActivity6 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Weryfikacja_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Weryfikacja_Telemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.Weryfikacja_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity3 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlersActivity7 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.StatusLeadu_Stracony = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Uruchomiony = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Umowa = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Wniosek = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Telefon = new System.Workflow.Activities.IfElseBranchActivity();
            this.setStateActivity26 = new System.Workflow.Activities.SetStateActivity();
            this.SetCT_Odrzucony = new System.Workflow.Activities.CodeActivity();
            this.Komunikat_Odrzucony = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity2 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setState_Odrzucony = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.Oferta_Routing = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged2 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_Oferta = new System.Workflow.Activities.CodeActivity();
            this.setState_Oferta = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity15 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.Telemarketing_Routing = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged3 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_Telemarketing = new System.Workflow.Activities.CodeActivity();
            this.setState_Telemarketing = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity16 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.faultHandlersActivity4 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.SetCT_Weryfikacja = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity14 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setState_Weryfikacja = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.faultHandlersActivity5 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Weryfikacja_Routing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity17 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged13 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity3 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.setStateActivity27 = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Routing = new System.Workflow.Activities.IfElseActivity();
            this.logRouter = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.faultHandlersActivity1 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
            this.StatusLead_Rozmowa = new System.Workflow.Activities.CodeActivity();
            this.logZainicjowany = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            this.stateInitializationActivity2 = new System.Workflow.Activities.StateInitializationActivity();
            this.Oferta_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity4 = new System.Workflow.Activities.StateInitializationActivity();
            this.Telemarketing_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity3 = new System.Workflow.Activities.StateInitializationActivity();
            this.stateInitializationActivity1 = new System.Workflow.Activities.StateInitializationActivity();
            this.Weryfikacja_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity15 = new System.Workflow.Activities.StateInitializationActivity();
            this.eventDrivenActivity1 = new System.Workflow.Activities.EventDrivenActivity();
            this.Odrzucenie = new System.Workflow.Activities.StateActivity();
            this.Oferta = new System.Workflow.Activities.StateActivity();
            this.Telemarketing = new System.Workflow.Activities.StateActivity();
            this.Weryfikacja = new System.Workflow.Activities.StateActivity();
            this.Navigator = new System.Workflow.Activities.StateActivity();
            this.Start = new System.Workflow.Activities.StateActivity();
            // 
            // setStateActivity5
            // 
            this.setStateActivity5.Enabled = false;
            this.setStateActivity5.Name = "setStateActivity5";
            this.setStateActivity5.TargetStateName = "AkceptacjaOferty";
            // 
            // setStateActivity10
            // 
            this.setStateActivity10.Name = "setStateActivity10";
            this.setStateActivity10.TargetStateName = "Odrzucenie";
            // 
            // StatusTelefon_Stracony
            // 
            this.StatusTelefon_Stracony.Enabled = false;
            this.StatusTelefon_Stracony.Name = "StatusTelefon_Stracony";
            // 
            // setStateActivity9
            // 
            this.setStateActivity9.Name = "setStateActivity9";
            this.setStateActivity9.TargetStateName = "Oferta";
            // 
            // StatusTelefon_Oferta
            // 
            this.StatusTelefon_Oferta.Enabled = false;
            this.StatusTelefon_Oferta.Name = "StatusTelefon_Oferta";
            // 
            // logERROR_WefyfikacjaInit
            // 
            this.logERROR_WefyfikacjaInit.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logERROR_WefyfikacjaInit.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logERROR_WefyfikacjaInit.HistoryDescription = "WeryfikacjaInit";
            this.logERROR_WefyfikacjaInit.HistoryOutcome = "ERR";
            this.logERROR_WefyfikacjaInit.Name = "logERROR_WefyfikacjaInit";
            this.logERROR_WefyfikacjaInit.OtherData = "";
            this.logERROR_WefyfikacjaInit.UserId = -1;
            // 
            // logERROR_WefyfikacjaEvent
            // 
            this.logERROR_WefyfikacjaEvent.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logERROR_WefyfikacjaEvent.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logERROR_WefyfikacjaEvent.HistoryDescription = "WeryfikacjaEvent";
            this.logERROR_WefyfikacjaEvent.HistoryOutcome = "ERR";
            this.logERROR_WefyfikacjaEvent.Name = "logERROR_WefyfikacjaEvent";
            this.logERROR_WefyfikacjaEvent.OtherData = "";
            this.logERROR_WefyfikacjaEvent.UserId = -1;
            // 
            // setStateActivity2
            // 
            this.setStateActivity2.Name = "setStateActivity2";
            this.setStateActivity2.TargetStateName = "Odrzucenie";
            // 
            // StatusRozmowa_Stracony
            // 
            this.StatusRozmowa_Stracony.Enabled = false;
            this.StatusRozmowa_Stracony.Name = "StatusRozmowa_Stracony";
            // 
            // setStateActivity4
            // 
            this.setStateActivity4.Name = "setStateActivity4";
            this.setStateActivity4.TargetStateName = "Telemarketing";
            // 
            // StatusRozmowa_Telefon
            // 
            this.StatusRozmowa_Telefon.Enabled = false;
            this.StatusRozmowa_Telefon.Name = "StatusRozmowa_Telefon";
            // 
            // setStateActivity3
            // 
            this.setStateActivity3.Name = "setStateActivity3";
            this.setStateActivity3.TargetStateName = "Oferta";
            // 
            // StatusRozmowa_Oferta
            // 
            this.StatusRozmowa_Oferta.Enabled = false;
            this.StatusRozmowa_Oferta.Name = "StatusRozmowa_Oferta";
            // 
            // logERROR_NavigatorInit
            // 
            this.logERROR_NavigatorInit.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logERROR_NavigatorInit.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logERROR_NavigatorInit.HistoryDescription = "NavigatorInit";
            this.logERROR_NavigatorInit.HistoryOutcome = "ERR";
            this.logERROR_NavigatorInit.Name = "logERROR_NavigatorInit";
            this.logERROR_NavigatorInit.OtherData = "";
            this.logERROR_NavigatorInit.UserId = -1;
            // 
            // Navigator_Stracony
            // 
            this.Navigator_Stracony.Name = "Navigator_Stracony";
            this.Navigator_Stracony.TargetStateName = "Odrzucenie";
            // 
            // Navigator_Uruchomienie
            // 
            this.Navigator_Uruchomienie.Name = "Navigator_Uruchomienie";
            this.Navigator_Uruchomienie.TargetStateName = "Uruchomienie";
            // 
            // Navigator_Umowa
            // 
            this.Navigator_Umowa.Name = "Navigator_Umowa";
            this.Navigator_Umowa.TargetStateName = "Umowa";
            // 
            // Navigator_Wniosek
            // 
            this.Navigator_Wniosek.Name = "Navigator_Wniosek";
            this.Navigator_Wniosek.TargetStateName = "Wniosek";
            // 
            // Navigator_Oferta
            // 
            this.Navigator_Oferta.Name = "Navigator_Oferta";
            this.Navigator_Oferta.TargetStateName = "Oferta";
            // 
            // Navigator_Telemarketing
            // 
            this.Navigator_Telemarketing.Name = "Navigator_Telemarketing";
            this.Navigator_Telemarketing.TargetStateName = "Telemarketing";
            // 
            // Oferta_AkceptacjaOferty
            // 
            this.Oferta_AkceptacjaOferty.Activities.Add(this.setStateActivity5);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOferta_AkceptacjaOferty);
            this.Oferta_AkceptacjaOferty.Condition = codecondition1;
            this.Oferta_AkceptacjaOferty.Name = "Oferta_AkceptacjaOferty";
            // 
            // Telemarketing_Odrzucenie
            // 
            this.Telemarketing_Odrzucenie.Activities.Add(this.StatusTelefon_Stracony);
            this.Telemarketing_Odrzucenie.Activities.Add(this.setStateActivity10);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsTelemarketing_Odrzucenie);
            this.Telemarketing_Odrzucenie.Condition = codecondition2;
            this.Telemarketing_Odrzucenie.Name = "Telemarketing_Odrzucenie";
            // 
            // Telemarketing_Oferta
            // 
            this.Telemarketing_Oferta.Activities.Add(this.StatusTelefon_Oferta);
            this.Telemarketing_Oferta.Activities.Add(this.setStateActivity9);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsTelemarketing_Oferta);
            this.Telemarketing_Oferta.Condition = codecondition3;
            this.Telemarketing_Oferta.Name = "Telemarketing_Oferta";
            // 
            // faultHandlerActivity4
            // 
            this.faultHandlerActivity4.Activities.Add(this.logERROR_WefyfikacjaInit);
            this.faultHandlerActivity4.Enabled = false;
            this.faultHandlerActivity4.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity4.Name = "faultHandlerActivity4";
            // 
            // faultHandlerActivity5
            // 
            this.faultHandlerActivity5.Activities.Add(this.logERROR_WefyfikacjaEvent);
            this.faultHandlerActivity5.Enabled = false;
            this.faultHandlerActivity5.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity5.Name = "faultHandlerActivity5";
            // 
            // faultHandlersActivity6
            // 
            this.faultHandlersActivity6.Name = "faultHandlersActivity6";
            // 
            // Weryfikacja_Odrzucenie
            // 
            this.Weryfikacja_Odrzucenie.Activities.Add(this.StatusRozmowa_Stracony);
            this.Weryfikacja_Odrzucenie.Activities.Add(this.setStateActivity2);
            codecondition4.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Odrzucenie);
            this.Weryfikacja_Odrzucenie.Condition = codecondition4;
            this.Weryfikacja_Odrzucenie.Name = "Weryfikacja_Odrzucenie";
            // 
            // Weryfikacja_Telemarketing
            // 
            this.Weryfikacja_Telemarketing.Activities.Add(this.StatusRozmowa_Telefon);
            this.Weryfikacja_Telemarketing.Activities.Add(this.setStateActivity4);
            codecondition5.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Telemarketing);
            this.Weryfikacja_Telemarketing.Condition = codecondition5;
            this.Weryfikacja_Telemarketing.Name = "Weryfikacja_Telemarketing";
            // 
            // Weryfikacja_Oferta
            // 
            this.Weryfikacja_Oferta.Activities.Add(this.StatusRozmowa_Oferta);
            this.Weryfikacja_Oferta.Activities.Add(this.setStateActivity3);
            codecondition6.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Oferta);
            this.Weryfikacja_Oferta.Condition = codecondition6;
            this.Weryfikacja_Oferta.Name = "Weryfikacja_Oferta";
            // 
            // faultHandlerActivity3
            // 
            this.faultHandlerActivity3.Activities.Add(this.logERROR_NavigatorInit);
            this.faultHandlerActivity3.Enabled = false;
            this.faultHandlerActivity3.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity3.Name = "faultHandlerActivity3";
            // 
            // faultHandlersActivity7
            // 
            this.faultHandlersActivity7.Name = "faultHandlersActivity7";
            // 
            // StatusLeadu_Stracony
            // 
            this.StatusLeadu_Stracony.Activities.Add(this.Navigator_Stracony);
            codecondition7.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Stracony);
            this.StatusLeadu_Stracony.Condition = codecondition7;
            this.StatusLeadu_Stracony.Name = "StatusLeadu_Stracony";
            // 
            // StatusLeadu_Uruchomiony
            // 
            this.StatusLeadu_Uruchomiony.Activities.Add(this.Navigator_Uruchomienie);
            codecondition8.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Uruchomiony);
            this.StatusLeadu_Uruchomiony.Condition = codecondition8;
            this.StatusLeadu_Uruchomiony.Enabled = false;
            this.StatusLeadu_Uruchomiony.Name = "StatusLeadu_Uruchomiony";
            // 
            // StatusLeadu_Umowa
            // 
            this.StatusLeadu_Umowa.Activities.Add(this.Navigator_Umowa);
            codecondition9.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Umowa);
            this.StatusLeadu_Umowa.Condition = codecondition9;
            this.StatusLeadu_Umowa.Enabled = false;
            this.StatusLeadu_Umowa.Name = "StatusLeadu_Umowa";
            // 
            // StatusLeadu_Wniosek
            // 
            this.StatusLeadu_Wniosek.Activities.Add(this.Navigator_Wniosek);
            codecondition10.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Wniosek);
            this.StatusLeadu_Wniosek.Condition = codecondition10;
            this.StatusLeadu_Wniosek.Enabled = false;
            this.StatusLeadu_Wniosek.Name = "StatusLeadu_Wniosek";
            // 
            // StatusLeadu_Oferta
            // 
            this.StatusLeadu_Oferta.Activities.Add(this.Navigator_Oferta);
            codecondition11.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Oferta);
            this.StatusLeadu_Oferta.Condition = codecondition11;
            this.StatusLeadu_Oferta.Name = "StatusLeadu_Oferta";
            // 
            // StatusLeadu_Telefon
            // 
            this.StatusLeadu_Telefon.Activities.Add(this.Navigator_Telemarketing);
            codecondition12.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Telefon);
            this.StatusLeadu_Telefon.Condition = codecondition12;
            this.StatusLeadu_Telefon.Name = "StatusLeadu_Telefon";
            // 
            // setStateActivity26
            // 
            this.setStateActivity26.Enabled = false;
            this.setStateActivity26.Name = "setStateActivity26";
            this.setStateActivity26.TargetStateName = "End";
            // 
            // SetCT_Odrzucony
            // 
            this.SetCT_Odrzucony.Enabled = false;
            this.SetCT_Odrzucony.Name = "SetCT_Odrzucony";
            // 
            // Komunikat_Odrzucony
            // 
            this.Komunikat_Odrzucony.Enabled = false;
            this.Komunikat_Odrzucony.Name = "Komunikat_Odrzucony";
            // 
            // logToHistoryListActivity2
            // 
            this.logToHistoryListActivity2.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity2.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity2.HistoryDescription = "::Odrzucony";
            this.logToHistoryListActivity2.HistoryOutcome = "";
            this.logToHistoryListActivity2.Name = "logToHistoryListActivity2";
            this.logToHistoryListActivity2.OtherData = "";
            this.logToHistoryListActivity2.UserId = -1;
            // 
            // setState_Odrzucony
            // 
            correlationtoken1.Name = "myWorkflowToken";
            correlationtoken1.OwnerActivityName = "Workflow1";
            this.setState_Odrzucony.CorrelationToken = correlationtoken1;
            this.setState_Odrzucony.Name = "setState_Odrzucony";
            this.setState_Odrzucony.State = 16;
            // 
            // Oferta_Routing
            // 
            this.Oferta_Routing.Activities.Add(this.Oferta_AkceptacjaOferty);
            this.Oferta_Routing.Name = "Oferta_Routing";
            // 
            // onWorkflowItemChanged2
            // 
            this.onWorkflowItemChanged2.AfterProperties = null;
            this.onWorkflowItemChanged2.BeforeProperties = null;
            correlationtoken2.Name = "myWorkflowToken";
            correlationtoken2.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged2.CorrelationToken = correlationtoken2;
            this.onWorkflowItemChanged2.Name = "onWorkflowItemChanged2";
            // 
            // SetCT_Oferta
            // 
            this.SetCT_Oferta.Enabled = false;
            this.SetCT_Oferta.Name = "SetCT_Oferta";
            // 
            // setState_Oferta
            // 
            correlationtoken3.Name = "myWorkflowToken";
            correlationtoken3.OwnerActivityName = "Workflow1";
            this.setState_Oferta.CorrelationToken = correlationtoken3;
            this.setState_Oferta.Name = "setState_Oferta";
            this.setState_Oferta.State = 18;
            // 
            // logToHistoryListActivity15
            // 
            this.logToHistoryListActivity15.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity15.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity15.HistoryDescription = "::Oferta";
            this.logToHistoryListActivity15.HistoryOutcome = "";
            this.logToHistoryListActivity15.Name = "logToHistoryListActivity15";
            this.logToHistoryListActivity15.OtherData = "";
            this.logToHistoryListActivity15.UserId = -1;
            // 
            // Telemarketing_Routing
            // 
            this.Telemarketing_Routing.Activities.Add(this.Telemarketing_Oferta);
            this.Telemarketing_Routing.Activities.Add(this.Telemarketing_Odrzucenie);
            this.Telemarketing_Routing.Name = "Telemarketing_Routing";
            // 
            // onWorkflowItemChanged3
            // 
            this.onWorkflowItemChanged3.AfterProperties = null;
            this.onWorkflowItemChanged3.BeforeProperties = null;
            correlationtoken4.Name = "myWorkflowToken";
            correlationtoken4.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged3.CorrelationToken = correlationtoken4;
            this.onWorkflowItemChanged3.Name = "onWorkflowItemChanged3";
            // 
            // SetCT_Telemarketing
            // 
            this.SetCT_Telemarketing.Enabled = false;
            this.SetCT_Telemarketing.Name = "SetCT_Telemarketing";
            // 
            // setState_Telemarketing
            // 
            correlationtoken5.Name = "myWorkflowToken";
            correlationtoken5.OwnerActivityName = "Workflow1";
            this.setState_Telemarketing.CorrelationToken = correlationtoken5;
            this.setState_Telemarketing.Name = "setState_Telemarketing";
            this.setState_Telemarketing.State = 17;
            // 
            // logToHistoryListActivity16
            // 
            this.logToHistoryListActivity16.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity16.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity16.HistoryDescription = "::Telemerketing";
            this.logToHistoryListActivity16.HistoryOutcome = "";
            this.logToHistoryListActivity16.Name = "logToHistoryListActivity16";
            this.logToHistoryListActivity16.OtherData = "";
            this.logToHistoryListActivity16.UserId = -1;
            // 
            // faultHandlersActivity4
            // 
            this.faultHandlersActivity4.Activities.Add(this.faultHandlerActivity4);
            this.faultHandlersActivity4.Name = "faultHandlersActivity4";
            // 
            // SetCT_Weryfikacja
            // 
            this.SetCT_Weryfikacja.Enabled = false;
            this.SetCT_Weryfikacja.Name = "SetCT_Weryfikacja";
            // 
            // logToHistoryListActivity14
            // 
            this.logToHistoryListActivity14.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity14.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity14.HistoryDescription = "::Weryfikacja";
            this.logToHistoryListActivity14.HistoryOutcome = "";
            this.logToHistoryListActivity14.Name = "logToHistoryListActivity14";
            this.logToHistoryListActivity14.OtherData = "";
            this.logToHistoryListActivity14.UserId = -1;
            // 
            // setState_Weryfikacja
            // 
            correlationtoken6.Name = "myWorkflowToken";
            correlationtoken6.OwnerActivityName = "Workflow1";
            this.setState_Weryfikacja.CorrelationToken = correlationtoken6;
            this.setState_Weryfikacja.Name = "setState_Weryfikacja";
            this.setState_Weryfikacja.State = 15;
            // 
            // faultHandlersActivity5
            // 
            this.faultHandlersActivity5.Activities.Add(this.faultHandlerActivity5);
            this.faultHandlersActivity5.Name = "faultHandlersActivity5";
            // 
            // Weryfikacja_Routing
            // 
            this.Weryfikacja_Routing.Activities.Add(this.Weryfikacja_Oferta);
            this.Weryfikacja_Routing.Activities.Add(this.Weryfikacja_Telemarketing);
            this.Weryfikacja_Routing.Activities.Add(this.Weryfikacja_Odrzucenie);
            this.Weryfikacja_Routing.Activities.Add(this.faultHandlersActivity6);
            this.Weryfikacja_Routing.Name = "Weryfikacja_Routing";
            // 
            // logToHistoryListActivity17
            // 
            this.logToHistoryListActivity17.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity17.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity17.HistoryDescription = "TTTTTT";
            this.logToHistoryListActivity17.HistoryOutcome = "";
            this.logToHistoryListActivity17.Name = "logToHistoryListActivity17";
            this.logToHistoryListActivity17.OtherData = "";
            this.logToHistoryListActivity17.UserId = -1;
            // 
            // onWorkflowItemChanged13
            // 
            this.onWorkflowItemChanged13.AfterProperties = null;
            this.onWorkflowItemChanged13.BeforeProperties = null;
            correlationtoken7.Name = "myWorkflowToken";
            correlationtoken7.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged13.CorrelationToken = correlationtoken7;
            this.onWorkflowItemChanged13.Name = "onWorkflowItemChanged13";
            // 
            // faultHandlersActivity3
            // 
            this.faultHandlersActivity3.Activities.Add(this.faultHandlerActivity3);
            this.faultHandlersActivity3.Name = "faultHandlersActivity3";
            // 
            // setStateActivity27
            // 
            this.setStateActivity27.Name = "setStateActivity27";
            this.setStateActivity27.TargetStateName = "Weryfikacja";
            // 
            // Navigator_Routing
            // 
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Telefon);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Oferta);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Wniosek);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Umowa);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Uruchomiony);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Stracony);
            this.Navigator_Routing.Activities.Add(this.faultHandlersActivity7);
            this.Navigator_Routing.Name = "Navigator_Routing";
            // 
            // logRouter
            // 
            this.logRouter.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logRouter.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logRouter.HistoryDescription = "::Router";
            this.logRouter.HistoryOutcome = "";
            this.logRouter.Name = "logRouter";
            this.logRouter.OtherData = "";
            this.logRouter.UserId = -1;
            // 
            // faultHandlersActivity1
            // 
            this.faultHandlersActivity1.Name = "faultHandlersActivity1";
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "Navigator";
            // 
            // StatusLead_Rozmowa
            // 
            this.StatusLead_Rozmowa.Enabled = false;
            this.StatusLead_Rozmowa.Name = "StatusLead_Rozmowa";
            // 
            // logZainicjowany
            // 
            this.logZainicjowany.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logZainicjowany.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logZainicjowany.HistoryDescription = "::Zainicjowany";
            this.logZainicjowany.HistoryOutcome = "";
            this.logZainicjowany.Name = "logZainicjowany";
            this.logZainicjowany.OtherData = "";
            this.logZainicjowany.UserId = -1;
            // 
            // onWorkflowActivated1
            // 
            correlationtoken8.Name = "myWorkflowToken";
            correlationtoken8.OwnerActivityName = "Workflow1";
            this.onWorkflowActivated1.CorrelationToken = correlationtoken8;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind1.Name = "Workflow1";
            activitybind1.Path = "workflowProperties";
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // stateInitializationActivity2
            // 
            this.stateInitializationActivity2.Activities.Add(this.setState_Odrzucony);
            this.stateInitializationActivity2.Activities.Add(this.logToHistoryListActivity2);
            this.stateInitializationActivity2.Activities.Add(this.Komunikat_Odrzucony);
            this.stateInitializationActivity2.Activities.Add(this.SetCT_Odrzucony);
            this.stateInitializationActivity2.Activities.Add(this.setStateActivity26);
            this.stateInitializationActivity2.Name = "stateInitializationActivity2";
            // 
            // Oferta_OnChange
            // 
            this.Oferta_OnChange.Activities.Add(this.onWorkflowItemChanged2);
            this.Oferta_OnChange.Activities.Add(this.Oferta_Routing);
            this.Oferta_OnChange.Name = "Oferta_OnChange";
            // 
            // stateInitializationActivity4
            // 
            this.stateInitializationActivity4.Activities.Add(this.logToHistoryListActivity15);
            this.stateInitializationActivity4.Activities.Add(this.setState_Oferta);
            this.stateInitializationActivity4.Activities.Add(this.SetCT_Oferta);
            this.stateInitializationActivity4.Name = "stateInitializationActivity4";
            // 
            // Telemarketing_OnChange
            // 
            this.Telemarketing_OnChange.Activities.Add(this.onWorkflowItemChanged3);
            this.Telemarketing_OnChange.Activities.Add(this.Telemarketing_Routing);
            this.Telemarketing_OnChange.Name = "Telemarketing_OnChange";
            // 
            // stateInitializationActivity3
            // 
            this.stateInitializationActivity3.Activities.Add(this.logToHistoryListActivity16);
            this.stateInitializationActivity3.Activities.Add(this.setState_Telemarketing);
            this.stateInitializationActivity3.Activities.Add(this.SetCT_Telemarketing);
            this.stateInitializationActivity3.Name = "stateInitializationActivity3";
            // 
            // stateInitializationActivity1
            // 
            this.stateInitializationActivity1.Activities.Add(this.setState_Weryfikacja);
            this.stateInitializationActivity1.Activities.Add(this.logToHistoryListActivity14);
            this.stateInitializationActivity1.Activities.Add(this.SetCT_Weryfikacja);
            this.stateInitializationActivity1.Activities.Add(this.faultHandlersActivity4);
            this.stateInitializationActivity1.Name = "stateInitializationActivity1";
            // 
            // Weryfikacja_OnChange
            // 
            this.Weryfikacja_OnChange.Activities.Add(this.onWorkflowItemChanged13);
            this.Weryfikacja_OnChange.Activities.Add(this.logToHistoryListActivity17);
            this.Weryfikacja_OnChange.Activities.Add(this.Weryfikacja_Routing);
            this.Weryfikacja_OnChange.Activities.Add(this.faultHandlersActivity5);
            this.Weryfikacja_OnChange.Name = "Weryfikacja_OnChange";
            // 
            // stateInitializationActivity15
            // 
            this.stateInitializationActivity15.Activities.Add(this.logRouter);
            this.stateInitializationActivity15.Activities.Add(this.Navigator_Routing);
            this.stateInitializationActivity15.Activities.Add(this.setStateActivity27);
            this.stateInitializationActivity15.Activities.Add(this.faultHandlersActivity3);
            this.stateInitializationActivity15.Name = "stateInitializationActivity15";
            // 
            // eventDrivenActivity1
            // 
            this.eventDrivenActivity1.Activities.Add(this.onWorkflowActivated1);
            this.eventDrivenActivity1.Activities.Add(this.logZainicjowany);
            this.eventDrivenActivity1.Activities.Add(this.StatusLead_Rozmowa);
            this.eventDrivenActivity1.Activities.Add(this.setStateActivity1);
            this.eventDrivenActivity1.Activities.Add(this.faultHandlersActivity1);
            this.eventDrivenActivity1.Name = "eventDrivenActivity1";
            // 
            // Odrzucenie
            // 
            this.Odrzucenie.Activities.Add(this.stateInitializationActivity2);
            this.Odrzucenie.Name = "Odrzucenie";
            // 
            // Oferta
            // 
            this.Oferta.Activities.Add(this.stateInitializationActivity4);
            this.Oferta.Activities.Add(this.Oferta_OnChange);
            this.Oferta.Name = "Oferta";
            // 
            // Telemarketing
            // 
            this.Telemarketing.Activities.Add(this.stateInitializationActivity3);
            this.Telemarketing.Activities.Add(this.Telemarketing_OnChange);
            this.Telemarketing.Name = "Telemarketing";
            // 
            // Weryfikacja
            // 
            this.Weryfikacja.Activities.Add(this.Weryfikacja_OnChange);
            this.Weryfikacja.Activities.Add(this.stateInitializationActivity1);
            this.Weryfikacja.Name = "Weryfikacja";
            // 
            // Navigator
            // 
            this.Navigator.Activities.Add(this.stateInitializationActivity15);
            this.Navigator.Name = "Navigator";
            // 
            // Start
            // 
            this.Start.Activities.Add(this.eventDrivenActivity1);
            this.Start.Name = "Start";
            // 
            // Workflow1
            // 
            this.Activities.Add(this.Start);
            this.Activities.Add(this.Navigator);
            this.Activities.Add(this.Weryfikacja);
            this.Activities.Add(this.Telemarketing);
            this.Activities.Add(this.Oferta);
            this.Activities.Add(this.Odrzucenie);
            this.CompletedStateName = null;
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "Start";
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

        }

        #endregion

        private SetStateActivity setStateActivity5;

        private SetStateActivity setStateActivity10;

        private CodeActivity StatusTelefon_Stracony;

        private SetStateActivity setStateActivity9;

        private CodeActivity StatusTelefon_Oferta;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logERROR_WefyfikacjaInit;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logERROR_WefyfikacjaEvent;

        private SetStateActivity setStateActivity2;

        private CodeActivity StatusRozmowa_Stracony;

        private SetStateActivity setStateActivity4;

        private CodeActivity StatusRozmowa_Telefon;

        private SetStateActivity setStateActivity3;

        private CodeActivity StatusRozmowa_Oferta;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logERROR_NavigatorInit;

        private SetStateActivity setStateActivity27;

        private SetStateActivity Navigator_Stracony;

        private SetStateActivity Navigator_Uruchomienie;

        private SetStateActivity Navigator_Umowa;

        private SetStateActivity Navigator_Wniosek;

        private SetStateActivity Navigator_Oferta;

        private SetStateActivity Navigator_Telemarketing;

        private IfElseBranchActivity Oferta_AkceptacjaOferty;

        private IfElseBranchActivity Telemarketing_Odrzucenie;

        private IfElseBranchActivity Telemarketing_Oferta;

        private FaultHandlerActivity faultHandlerActivity4;

        private FaultHandlerActivity faultHandlerActivity5;

        private FaultHandlersActivity faultHandlersActivity6;

        private IfElseBranchActivity Weryfikacja_Odrzucenie;

        private IfElseBranchActivity Weryfikacja_Telemarketing;

        private IfElseBranchActivity Weryfikacja_Oferta;

        private FaultHandlerActivity faultHandlerActivity3;

        private FaultHandlersActivity faultHandlersActivity7;

        private IfElseBranchActivity StatusLeadu_Stracony;

        private IfElseBranchActivity StatusLeadu_Uruchomiony;

        private IfElseBranchActivity StatusLeadu_Umowa;

        private IfElseBranchActivity StatusLeadu_Wniosek;

        private IfElseBranchActivity StatusLeadu_Oferta;

        private IfElseBranchActivity StatusLeadu_Telefon;

        private SetStateActivity setStateActivity26;

        private CodeActivity SetCT_Odrzucony;

        private CodeActivity Komunikat_Odrzucony;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity2;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Odrzucony;

        private IfElseActivity Oferta_Routing;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged2;

        private CodeActivity SetCT_Oferta;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Oferta;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity15;

        private IfElseActivity Telemarketing_Routing;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged3;

        private CodeActivity SetCT_Telemarketing;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Telemarketing;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity16;

        private FaultHandlersActivity faultHandlersActivity4;

        private CodeActivity SetCT_Weryfikacja;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity14;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Weryfikacja;

        private FaultHandlersActivity faultHandlersActivity5;

        private IfElseActivity Weryfikacja_Routing;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity17;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged13;

        private FaultHandlersActivity faultHandlersActivity3;

        private IfElseActivity Navigator_Routing;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logRouter;

        private FaultHandlersActivity faultHandlersActivity1;

        private SetStateActivity setStateActivity1;

        private CodeActivity StatusLead_Rozmowa;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logZainicjowany;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;

        private StateInitializationActivity stateInitializationActivity2;

        private EventDrivenActivity Oferta_OnChange;

        private StateInitializationActivity stateInitializationActivity4;

        private EventDrivenActivity Telemarketing_OnChange;

        private StateInitializationActivity stateInitializationActivity3;

        private StateInitializationActivity stateInitializationActivity1;

        private EventDrivenActivity Weryfikacja_OnChange;

        private StateInitializationActivity stateInitializationActivity15;

        private EventDrivenActivity eventDrivenActivity1;

        private StateActivity Odrzucenie;

        private StateActivity Oferta;

        private StateActivity Telemarketing;

        private StateActivity Weryfikacja;

        private StateActivity Navigator;

        private StateActivity Start;



    }
}
