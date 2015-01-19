using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;

namespace KontraktSMW.Workflow1
{
    public sealed partial class Workflow1 : StateMachineWorkflowActivity
    {
        public Workflow1()
        {
            InitializeComponent();
        }

        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        #region Warunki logiczne Navigatora

        private void IsStatusLeadu_Telefon(object sender, ConditionalEventArgs e)
        {
            e.Result = NavigatorCodeConditionResult("colStatusLeadu", "Rozmowa");
        }

        private void IsStatusLeadu_Umowa(object sender, ConditionalEventArgs e)
        {
            e.Result = NavigatorCodeConditionResult("colStatusLeadu", "Umowa");
        }

        private void IsStatusLeadu_Wniosek(object sender, ConditionalEventArgs e)
        {
            e.Result = NavigatorCodeConditionResult("colStatusLeadu", "Wniosek");
        }

        private void IsStatusLeadu_Oferta(object sender, ConditionalEventArgs e)
        {
            e.Result = NavigatorCodeConditionResult("colStatusLeadu", "Oferta");
        }

        private void IsStatusLeadu_Uruchomiony(object sender, ConditionalEventArgs e)
        {
            e.Result = NavigatorCodeConditionResult("colStatusLeadu", "Uruchomiony");
        }

        private void IsStatusLeadu_Stracony(object sender, ConditionalEventArgs e)
        {
            e.Result = NavigatorCodeConditionResult("colStatusLeadu", "Stracony");
        }

        #endregion

        #region Warunki logiczne

        //Weryfikacja

        private void IsWeryfikacja_Oferta(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Weryfikacja", "Przygotuj ofertę");
        }

        private void IsWeryfikacja_Telemarketing(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Weryfikacja", "Telemarketing");
        }

        private void IsWeryfikacja_Odrzucenie(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Weryfikacja", "Odrzuć");
        }

        //Telemarketing

        private void IsTelemarketing_Oferta(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Telemarketing", "Przygotuj ofertę");
        }

        private void IsTelemarketing_Odrzucenie(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Telemarketing", "Odrzuć");
        }


        //Oferta, Korekta Oferty

        private void IsOferta_AkceptacjaOferty(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Oferta", "Oferta wysłana");

        }

        //Akceptacja Oferty

        private void IsAkceptacjaOferty_Wniosek(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaOferty", "Przygotuj wniosek");
        }

        private void IsAkceptacjaOferty_Odrzucenie(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaOferty", "Odrzuć");
        }

        private void IsAkceptacjaOferty_KorektaOferty(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaOferty", "Oferta do korekty");
        }

        private void IsAkceptacjaOferty_Telemarketing(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaOferty", "Telemarketing");
        }

        //Wniosek, Korekta Wniosku

        private void IsWniosek_AkceptacjaWniosku(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Wniosek", "Wniosek wysłany");
        }

        //Akceptacja wniosku

        private void IsAkceptacjaWniosku_Umowa(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaWniosku", "Przygotuj umowę");
        }

        private void IsAkceptacjaWniosku_KorektaWniosku(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaWniosku", "Wniosek do korekty");
        }

        private void IsAkceptacjaWniosku_Odrzucenie(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaWniosku", "Odrzuć");
        }


        //Umowa

        private void IsUmowa_AkceptacjaUmowy(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Umowa", "Umowa wysłana");
        }

        //Akceptacja umowy

        private void IsAkceptacjaUmowy_Uruchomienie(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaUmowy", "Uruchomienie");
        }

        private void IsAkceptacjaUmowy_Odrzucenie(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaUmowy", "Odrzuć");
        }

        private void IsAkceptacjaUmowy_Telemarketing(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_AkceptacjaUmowy", "Telemarketing");
        }

        //Uruchomienie

        private void IsUruchomienie_Dokumentacja(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Uruchomienie", "Przygotuj dokumentację");
        }

        //Dokumentacja

        private void IsDokumentacja_Rozliczenie(object sender, ConditionalEventArgs e)
        {
            e.Result = CodeConditionResult("cmdKontrakt_Dokumentacja", "Dokumentacja wysłana");
        }

        #endregion

        #region Warunki logiczne - Helpers

        private bool NavigatorCodeConditionResult(string strStatusColumnName, string strStatus)
        {
            if (workflowProperties.Item[strStatusColumnName] != null)
            {
                if (workflowProperties.Item[strStatusColumnName].ToString() == strStatus)
                {
                    return true;
                }
            }

            return false;
        }

        private bool CodeConditionResult(string strCommandColumnName, string strAction)
        {
            if (workflowProperties.Item[strCommandColumnName] != null)
            {
                if (workflowProperties.Item[strCommandColumnName].ToString() == strAction)
                {
                    try
                    {
                        workflowProperties.Item[strCommandColumnName] = string.Empty;
                        workflowProperties.Item.Update();
                    }
                    catch (Exception)
                    { }

                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
