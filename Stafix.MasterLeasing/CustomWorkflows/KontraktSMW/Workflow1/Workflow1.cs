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
using System.Text;
using System.Net.Mail;

namespace KontraktSMW.Workflow1
{
    public sealed partial class Workflow1 : StateMachineWorkflowActivity
    {
        const string _LEAD_ = "Lead";
        const string _ROZMOWA_ = "Rozmowa";
        const string _OFERTA_ = "Oferta";
        const string _WNIOSEK_ = "Wniosek";
        const string _UMOWA_ = "Umowa";
        const string _TELEFON_ = "Telefon";
        const string _STRACONY_ = "Stracony";
        const string _URUCHOMIONY_ = "Uruchomiony";

        public Workflow1()
        {
            InitializeComponent();
        }

        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        public String logRozliczenie_DodajDoRozliczen = default(System.String);
        //public Komunikat message = new Komunikat();

        #region Warunki logiczne Navigatora

        private void IsStatusLeadu_Telefon(object sender, ConditionalEventArgs e)
        {
            e.Result = NavigatorCodeConditionResult("colStatusLeadu", "Telefon");
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

        private void IsStatusLeadu_ElseIf(object sender, ConditionalEventArgs e)
        {
            e.Result = true;
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

        #region Ustawianie CT

        private void SetCT_Weryfikacja_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.Weryfikacja", "Rozmowa", "cmdKontrakt_Weryfikacja", true);
        }

        private void SetCT_Telemarketing_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.Telemarketing", "Telefon", "cmdKontrakt_Telemarketing", true);
        }

        private void SetCT_Oferta_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.Oferta", "Oferta", "cmdKontrakt_Oferta", true);
        }

        private void SetCT_AkceptacjaOferty_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.AkceptacjaOferty", "Oferta", "cmdKontrakt_AkceptacjaOferty", true);
        }

        private void SetCT_Wniosek_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.Wniosek", "Wniosek", "cmdKontrakt_Wniosek", true);
        }

        private void SetCT_AkceptacjaWniosku_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.AkceptacjaWniosku", "Wniosek", "cmdKontrakt_AkceptacjaWniosku", true);
        }

        private void SetCT_Umowa_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.Umowa", "Umowa", "cmdKontrakt_Umowa", true);
        }

        private void SetCT_AkceptacjaUmowy_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.AkceptacjaUmowy", "Umowa", "cmdKontrakt_AkceptacjaUmowy", true);
        }

        private void SetCT_Uruchomienie_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.Uruchomienie", "Uruchomienie", "cmdKontrakt_Uruchomienie", false);
        }

        private void SetCT_Dokumentacja_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.Dokumentacja", "Uruchomienie", "cmdKontrakt_Dokumentacja", false);
        }

        private void SetCT_Rozliczenie_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.Rozliczenie", "Rozliczenie", string.Empty, false);
        }

        private void SetCT_Odrzucony_ExecuteCode(object sender, EventArgs e)
        {
            AdjustFormSettings("ctKontrakt.Odrzucenie", "Stracony", string.Empty, false);
        }

        #endregion

        #region CT - Helpers

        private void AdjustFormSettings(string strContentType, string strStatusLeadu, string strCommandColumnName, bool clearPowodOdrzucenia)
        {

            workflowProperties.Item["ContentType"] = strContentType;

            workflowProperties.Item["colStatusLeadu"] = strStatusLeadu;


            if (clearPowodOdrzucenia == true)
            {
                workflowProperties.Item["colPowodOdrzucenia"] = string.Empty;
            }

            if (!string.IsNullOrEmpty(strCommandColumnName))
            {
                if (workflowProperties.Item[strCommandColumnName] != null)
                {
                    //wyczyść pole komendy
                    workflowProperties.Item[strCommandColumnName] = string.Empty; ;
                }
            }


            workflowProperties.Item.Update();
        }

        #endregion

        #region Obsługa raportowania zmian statusu

        /// <summary>
        /// procedura obsługi zmian statusu rejestruje zmiany statusu wniosku w danym dniu roboczym
        /// pierwsze wywołąnie procedury zakłada rekord w tablicy tabKontrakty_Aktywności
        /// kolejne wywołania modyfikują status końcowy wniosku
        /// </summary>
        /// <param name="statusSTART"></param>
        /// <param name="statusEND"></param>
        private void StatusChangeUpdate(string statusSTART, string statusEND)
        {
            int kontraktID = workflowProperties.ItemId;
            const string _tabKontraktyAktywnosci_ = "tabKontrakty_Aktywnosci";

            using (SPSite site = new SPSite(workflowProperties.SiteId))
            {
                //using (SPWeb web = site.OpenWeb())
                using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder(@"<Where><And><Eq><FieldRef Name='colLinkDoKontraktu'/><Value Type='Text'>{__kontraktID__}</Value></Eq><Eq><FieldRef Name='colData'/><Value Type='DateTime'><Today/></Value></Eq></And></Where>");
                    sb.Replace("{__kontraktID__}", kontraktID.ToString());
                    string camlQuery = sb.ToString();

                    SPList list = web.Lists[_tabKontraktyAktywnosci_];
                    SPQuery query = new SPQuery();
                    //query.ViewFields = @"";
                    query.Query = camlQuery;

                    SPListItemCollection items = list.GetItems(query);
                    if (items.Count == 1)
                    {
                        SPListItem item = items[0];
                        //item["colStatusPoczatkowy"] = statusSTART;
                        item["colStatusKoncowy"] = statusEND;
                        item.Update();
                    }
                    else
                    {
                        //dodaj nowy rekord
                        SPListItem item = list.AddItem();
                        item["colLinkDoKontraktu"] = kontraktID;
                        item["colData"] = DateTime.Now;
                        item["colStatusPoczatkowy"] = statusSTART;
                        item["colStatusKoncowy"] = statusEND;
                        item.Update();

                    }
                }
            }
        }

        private void StatusLead_Rozmowa_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_LEAD_, _ROZMOWA_);
        }

        private void StatusRozmowa_Oferta_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_ROZMOWA_, _OFERTA_);
        }

        private void StatusRozmowa_Telefon_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_ROZMOWA_, _TELEFON_);
        }

        private void StatusRozmowa_Stracony_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_ROZMOWA_, _STRACONY_);
        }

        private void StatusTelefon_Oferta_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_TELEFON_, _OFERTA_);
        }

        private void StatusTelefon_Stracony_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_TELEFON_, _STRACONY_);
        }

        private void StatusOferta_Wniosek_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_OFERTA_, _WNIOSEK_);
        }

        private void StatusOferta_Stracony_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_OFERTA_, _STRACONY_);
        }

        private void StatusOferta_Telefon_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_OFERTA_, _TELEFON_);
        }

        private void StatusWniosek_Umowa_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_WNIOSEK_, _UMOWA_);
        }

        private void StatusWniosek_Stracony_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_WNIOSEK_, _STRACONY_);
        }

        private void StatusUmowa_Uruchomienie_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_UMOWA_, _URUCHOMIONY_);
        }

        private void StatusUmowa_Stracony_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_UMOWA_, _STRACONY_);
        }

        private void StatusUmowa_Telefon_ExecuteCode(object sender, EventArgs e)
        {
            StatusChangeUpdate(_UMOWA_, _TELEFON_);
        }

        #endregion

        #region Obsługa zasilania tablicy z rozliczeniami prowizji

        private void nRozliczenie_DodajDoRozliczen_ExecuteCode(object sender, EventArgs e)
        {
            int kontraktID = workflowProperties.ItemId;

            using (SPSite site = new SPSite(workflowProperties.SiteId))
            {
                //using (SPWeb web = site.OpenWeb())
                using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder(@"<Where><Eq><FieldRef Name='colLinkDoKontraktu'/><Value Type='Text'>{__kontraktID__}</Value></Eq></Where>");
                    sb.Replace("{__kontraktID__}", kontraktID.ToString());
                    string camlQuery = sb.ToString();

                    SPList list = web.Lists["tabRozliczeniaKontraktow"];
                    SPQuery query = new SPQuery();
                    //query.ViewFields = @"";
                    query.Query = camlQuery;

                    SPListItemCollection items = list.GetItems(query);
                    if (items.Count == 0)
                    {
                        try
                        {
                            //dodaj nowy rekord
                            SPListItem item = list.AddItem();
                            item["colLinkDoKontraktu"] = kontraktID;
                            item["colWartoscKontraktuPLN"] = workflowProperties.Item["colWartoscKontraktuPLN"];
                            item["colProwizja"] = workflowProperties.Item["colProwizja"];
                            item["colNumerUmowy_Kontrakt"] = workflowProperties.Item["colNumerUmowy_Kontrakt"];
                            item["colDataUruchomienia_Kontrakt"] = workflowProperties.Item["colDataUruchomienia_Kontrakt"];
                            item["colDataZakonczenia_Kontrakt"] = workflowProperties.Item["colDataZakonczenia_Kontrakt"];
                            item["colUstalenia"] = workflowProperties.Item["colUstalenia"];
                            item.Update();

                            logRozliczenie_DodajDoRozliczen = "Dodano nowy rekord w kartotece rozliczeń prowizji";
                        }
                        catch (Exception exp)
                        {
                            throw;
                        }


                    }
                    else
                    {
                        logRozliczenie_DodajDoRozliczen = "Nie dodano nowego rekordu - rekord już istnieje w kartotece rozliczeń prowizji";
                    }

                }
            }
        }

        #endregion

        #region Komunikaty

        private void Komunikat_Odrzucony_ExecuteCode(object sender, EventArgs e)
        {

            //try
            //{
            //    if (IsKomunikatUpdated())
            //    {
            //        string strSubject = string.Format("Klient:{0} {1} :: stracony",
            //                message.Klient.ToString(),
            //                message.DataZgloszenia.ToShortDateString());

            //        StringBuilder sb = new StringBuilder();
            //        sb.AppendFormat("<h2>Szczegóły kontraktu:<h2>");
            //        sb.AppendFormat("<ul>");
            //        sb.AppendFormat("<li>{0}:{1}</li>", "Klient", message.Klient.ToString());
            //        sb.AppendFormat("<li>{0}:{1}</li>", "Data Zgłoszenia", message.DataZgloszenia.ToShortDateString());
            //        sb.AppendFormat("<li>{0}:{1}</li>", "Wartość PLN", message.WartoscPLN.ToString());
            //        sb.AppendFormat("<li>{0}:{1}</li>", "Cel Finansowania", message.CelFinansowania.ToString());
            //        sb.AppendFormat("<li>{0}:{1}</li>", "Ustalenia", message.Ustalenia.ToString());
            //        sb.AppendFormat("<li>{0}:{1}</li>", "Status", message.StatusLeadu.ToString());
            //        sb.AppendFormat("</ul>");

            //        string strBody = sb.ToString();

            //        KomunikatDlaAgenta(strSubject, strBody);
            //    }

            //}
            //catch (Exception exp)
            //{
            //    throw;
            //}

        }

        private void Komunikat_AkceptacjaOferty_ExecuteCode(object sender, EventArgs e)
        {
            //KomunikatDlaAgenta(
            //    string.Format("Kontrakt #{0}: oferta zaakceptowana przez Klienta", workflowProperties.ItemId.ToString()), "");
        }

        private void Komunikat_AkceptacjaWniosku_ExecuteCode(object sender, EventArgs e)
        {
            //KomunikatDlaAgenta(
            //    string.Format("Kontrakt #{0}: wniosek zaakceptowany przez Bank", workflowProperties.ItemId.ToString()), "");
        }

        private void Komunikat_WniosekOdrzucony_ExecuteCode(object sender, EventArgs e)
        {
            //KomunikatDlaAgenta(
            //    string.Format("Kontrakt #{0}: wniosek odrzucony przez Bank", workflowProperties.ItemId.ToString()), "");

        }

        private void Komunikat_OfertaNiezaakceptowana_ExecuteCode(object sender, EventArgs e)
        {
            //KomunikatDlaAgenta(
            //    string.Format("Kontrakt #{0}: oferta odrzucona przez Klienta", workflowProperties.ItemId.ToString()), "");

        }

        private void Komunikat_UmowaUruchomiona_ExecuteCode(object sender, EventArgs e)
        {
            //KomunikatDlaAgenta(
            //    string.Format("Kontrakt #{0}: umowa uruchomiona", workflowProperties.ItemId.ToString()), "");

        }

        private void Komunikat_UmowaStracona_ExecuteCode(object sender, EventArgs e)
        {
            //KomunikatDlaAgenta(
            //     string.Format("Kontrakt #{0}: umowa stracona", workflowProperties.ItemId.ToString()), "");

        }

        private void Komunikat_UmowaNiezaakceptowana_ExecuteCode(object sender, EventArgs e)
        {
            //KomunikatDlaAgenta(
            //     string.Format("Kontrakt #{0}: umowa niezaakceptowana przez Klienta", workflowProperties.ItemId.ToString()), "Klient przekazany do Telemarketingu");

        }

        #endregion

        #region Komunikaty.Procedury

        private bool IsKomunikatUpdated()
        {
            return false;

            //try
            //{
            //    if (workflowProperties.Item["colDataZgloszenia"] != null)
            //    {
            //        message.DataZgloszenia = Convert.ToDateTime(workflowProperties.Item["colDataZgloszenia"]);
            //    }

            //    if (workflowProperties.Item["colKlient"] != null)
            //    {
            //        message.Klient = workflowProperties.Item["colKlient"].ToString();
            //    }
            //    else
            //    {
            //        message.Klient = string.Empty;
            //    }

            //    if (workflowProperties.Item["colWartoscPLN"] != null)
            //    {
            //        SPFieldCurrency price = (SPFieldCurrency)workflowProperties.Item["colWartoscPLN"];

            //        message.WartoscPLN = price.GetFieldValueAsText(workflowProperties.Item["colWartoscPLN"]);
            //    }
            //    else
            //    {
            //        message.WartoscPLN = String.Empty;
            //    }

            //    if (workflowProperties.Item["colCelFinansowania"] != null)
            //    {
            //        message.CelFinansowania = (string)workflowProperties.Item["colCelFinansowania"];
            //    }
            //    else
            //    {
            //        message.CelFinansowania = string.Empty;
            //    }

            //    if (workflowProperties.Item["colUstalenia"] != null)
            //    {
            //        message.Ustalenia = workflowProperties.Item["colUstalenia"].ToString();
            //    }
            //    else
            //    {
            //        message.Ustalenia = string.Empty;
            //    }

            //    if (workflowProperties.Item["colStatusLeadu"] != null)
            //    {
            //        message.StatusLeadu = workflowProperties.Item["colStatusLeadu"].ToString();
            //    }
            //    else
            //    {
            //        message.StatusLeadu = String.Empty;
            //    }


            //    return true;
            //}
            //catch (Exception exp)
            //{
            //    throw;
            //}

            //return false;
        }

        private void KomunikatDlaAgenta(string tematWiadomosci, string trescWiadomosci)
        {
            //znajdź identyfikator kartoteki agenta

            int partnerID = 0;
            string emailAgenta = string.Empty;

            if (workflowProperties.Item["colPartner.OsobaKontaktowa"] != null)
            {
                string idValue = workflowProperties.Item["colPartner.OsobaKontaktowa"].ToString();
                int partial = idValue.LastIndexOf(";");
                string idPure = idValue.Substring(0, partial);

                partnerID = Convert.ToInt32(idPure);
                emailAgenta = GetEmailAgenta(partnerID);
            }


            //sprawdź czy na kartotece jest włączona subskrybcja wiadomości
            if (partnerID > 0 &&
                emailAgenta != string.Empty &&
                IsSubskrybcjaWiadomociAktywna(partnerID))
            {
                using (SPSite site = new SPSite(workflowProperties.SiteId))
                {

                    using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                    {
                        SPList list = web.Lists["tabKolejkaWiadomosciEmail"];

                        SPListItem item = list.AddItem();

                        item["colDataPlanowanejWysylki"] = DateTime.Now;
                        item["colEmailOdbiorcyWiadomosci"] = emailAgenta.ToString();
                        //item["colEmailOdbiorcyKopiiWiadomosci"] =
                        //item["colEmailNadawcyWiadomosci"] =
                        item["colTematWiadomosci"] = tematWiadomosci.ToString();
                        item["colTrescWiadomosci"] = trescWiadomosci.ToString();
                        //item["colBodyHTML"] =
                        //item["colStopkaWiadomosciHTML"] =
                        item.Update();

                    }
                }
            }
        }

        private string GetEmailAgenta(int partnerID)
        {
            using (SPSite site = new SPSite(workflowProperties.SiteId))
            {
                using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder(@"<Where><Eq><FieldRef Name='ID'/><Value Type='Counter'>{__partnerID__}</Value></Eq></Where>");
                    sb.Replace("{__partnerID__}", partnerID.ToString());
                    string camlQuery = sb.ToString();

                    SPList list = web.Lists[@"tabPartnerzy"];
                    SPQuery query = new SPQuery();
                    query.ViewFields = @"";
                    query.Query = camlQuery;

                    SPListItemCollection items = list.GetItems(query);
                    if (items.Count == 1)
                    {
                        SPListItem item = items[0];

                        if (item["colEmailOsobyKontaktowej"] != null)
                        {
                            return item["colEmailOsobyKontaktowej"].ToString();
                        }
                    }
                }

                return String.Empty;
            }
        }

        private bool IsSubskrybcjaWiadomociAktywna(int partnerID)
        {
            using (SPSite site = new SPSite(workflowProperties.SiteId))
            {
                using (SPWeb web = site.AllWebs[workflowProperties.WebId])
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder(@"<Where><Eq><FieldRef Name='ID'/><Value Type='Counter'>{__partnerID__}</Value></Eq></Where>");
                    sb.Replace("{__partnerID__}", partnerID.ToString());
                    string camlQuery = sb.ToString();

                    SPList list = web.Lists[@"tabPartnerzy"];
                    SPQuery query = new SPQuery();
                    query.ViewFields = @"";
                    query.Query = camlQuery;

                    SPListItemCollection items = list.GetItems(query);
                    if (items.Count == 1)
                    {
                        SPListItem item = items[0];

                        if ((bool)item["colAktywny"] == true)
                        {
                            if ((bool)item["colWysylkaRaportuTygodniowego"] == true)
                            {
                                return true;
                            }
                        }

                    }
                }

                return false;
            }
        }

        #endregion

        #region Helpers

        public bool SendDirectMail(string subject, string body)
        {
            //Ustaw dla każdego modułu indywidualnie
            string from = "ERR.ML.ObslugaKontraktu<noreply@stafix24.pl>";
            string to = "biuro@rawcom24.pl";


            //TurboSMTP config parameters
            const string sMTPServerName = "pro.turbo-smtp.com";//
            const string sMTPLoginName = "biuro@rawcom24.pl";
            const string sMTPPassword = "Rogalaewa1";
            const int sMTPPort = 587;

            MailMessage msg = new MailMessage(from, to);
            msg.Subject = subject;
            msg.Body = body;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient(sMTPServerName, sMTPPort);
            System.Net.NetworkCredential basicCredential = new System.Net.NetworkCredential(sMTPLoginName, sMTPPassword);
            client.EnableSsl = false;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential;
            try
            {
                client.Send(msg);
            }
            catch (Exception)
            {
                WriteToHistoryLog("DirectSendMail", "ERR");
                return false;
            }

            return true;
        }

        private void CustomErrorHandler(Exception e)
        {

            StringBuilder sb = new StringBuilder();

            try
            {
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Message", e.Message.ToString());
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Source", e.Source.ToString());
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Target Site", e.TargetSite.ToString());
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Stack Trace", e.StackTrace.ToString());
                sb.AppendFormat(@"<table><tr><td>{0}</td><td>{1}</td></tr></table>", "Workflow Context", workflowProperties.Context.ToString());

            }
            catch (Exception)
            {
                sb.AppendLine("Problem z odczytem pozostałych szczegółów");
            }

            WriteToHistoryLog(e.Message.ToString(), "ERR");

            SendDirectMail(e.Message.ToString(), sb.ToString());

        }

        private void WriteToHistoryLog(string description, string outcome)
        {
            SPWeb web = workflowProperties.Web;
            Guid workflow = workflowProperties.WorkflowId;

            TimeSpan ts = new TimeSpan();
            SPWorkflow.CreateHistoryEvent(web, workflow, 0, web.CurrentUser, ts,
                outcome, description, string.Empty);
        }

        #endregion

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            WriteToHistoryLog("to jest opis testowy", "TEST");
            SendDirectMail("To jest przykłądowy tytuł", "to jest przykładowa treść");
        }

    }
}
