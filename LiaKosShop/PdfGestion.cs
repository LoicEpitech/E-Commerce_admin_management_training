using GestionBD.MySQL;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LiaKosShop
{
    internal class PdfGestion
    {
        public static void CreationPDF(Dictionary<string, (int, int)> dicLigneCommande, int idClient, string dateCommande, int idCommande)
        {
            // Définir les paramètres pour remplir le PDF \\
            // ↓↓ Partie Header ↓↓ \\
            string titreNomBoutique = "LiaKosShop";
            string adressEntreprise = "8 Rue du test";
            string villeCpEntreprise = "Béziers, 34500";
            string telephoneEntreprise = "Téléphone: 06 111111111";
            string faxEntreprise = "Fax: (523) 452-956";
            string webSite = "SiteWeb: https://LiaKosShop.fr";
            string emailEntreprise = "LoicNoro@gmail.com";
            // ↑↑ Partie Header ↑↑ \\
            //  ↓↓ Partie Client (Right) ↓↓ \\
            DataRow leClient = GestionClients.getTupleById(idClient);
            string nomClient = leClient[3].ToString();
            string nomEntrepriseClient = "";
            string adressClient = leClient[7].ToString();
            string villeCpClient = leClient[9].ToString()+", "+ leClient[8].ToString();
            string telephoneClient = "Téléphone: "+ leClient[6].ToString();
            //  ↑↑ Partie Client (Right) ↑↑ \\
            //  ↓↓ Partie Header Tableaux ↓↓ \\
            string typeAchat = "Equipement Electronique";
            string livreur = "La Poste";
            string dateLivraisonEstimer = "00/00/0000";
            //  ↑↑ Partie Header Tableaux ↑↑ \\
            //  ↓↓ Partie Recap Total ↓↓ \\
            string taxFacture = "10";
            //  ↑↑ Partie Recap Total ↑↑ \\


            // Chemin vers le fichier PDF de modèle
            string templatePdfPath = "../../../pdfCmd/template/PDFCommandeV4.pdf";

            // Chemin de sortie pour le nouveau fichier PDF rempli
            string outputPdfPath = "../../../pdfCmd/PDFCommandeN"+ idCommande + "_"+ leClient[3] + "-"+ leClient[4] + ".pdf";

            RemplirPDF(templatePdfPath, outputPdfPath, titreNomBoutique, adressEntreprise, villeCpEntreprise, telephoneEntreprise, faxEntreprise, webSite, emailEntreprise, nomClient, nomEntrepriseClient, adressClient, villeCpClient, telephoneClient, typeAchat, livreur, dateLivraisonEstimer, taxFacture, dicLigneCommande);
        }

        static void RemplirPDF(string templatePdfPath, string outputPdfPath, string titreNomBoutique, string adressEntreprise, string villeCpEntreprise, string telephoneEntreprise, string faxEntreprise, string webSite, string emailEntreprise, string nomClient, string nomEntrepriseClient, string adressClient, string villeCpClient, string telephoneClient, string typeAchat, string livreur, string dateLivraisonEstimer, string taxFacture, Dictionary<string, (int, int)> dicLigneCommande)
        {
            using (var existingFileStream = new FileStream(templatePdfPath, FileMode.Open))
            using (var newFileStream = new FileStream(outputPdfPath, FileMode.Create))
            {
                // Ouvrir le document PDF existant
                var pdfReader = new PdfReader(existingFileStream);
                var stamper = new PdfStamper(pdfReader, newFileStream);

                // Obtenez les champs de formulaire éditables du PDF
                var formFields = stamper.AcroFields;

                // Remplir les champs de formulaire avec les valeurs spécifiées
                formFields.SetField("TextRefCommande", "06669");
                formFields.SetField("TextDateCommande", Convert.ToString(DateTime.Now.Date));
                formFields.SetField("TextTitreNomBoutique", titreNomBoutique);
                formFields.SetField("TextHeaderAdressEntreprise", adressEntreprise);
                formFields.SetField("TextHeaderVilleCpEntreprise", villeCpEntreprise);
                formFields.SetField("TextHeaderTelephoneEntreprise", telephoneEntreprise);
                formFields.SetField("TextHeaderFaxEntreprise", faxEntreprise);
                formFields.SetField("TextHeaderWebSiteEntreprise", webSite);
                formFields.SetField("TextNomBoutique", titreNomBoutique);
                formFields.SetField("TextEmailEntreprise", emailEntreprise);
                formFields.SetField("TextAddressEntreprise", adressEntreprise);
                formFields.SetField("TextVilleCpEntreprise", villeCpEntreprise);
                formFields.SetField("TextTelephoneEntreprise", telephoneEntreprise);
                formFields.SetField("TextFaxEntreprise", faxEntreprise);
                formFields.SetField("TextNomClient", nomClient);
                formFields.SetField("TextNomEntrepriseClient", nomEntrepriseClient);
                formFields.SetField("TextAdresseClient", adressClient);
                formFields.SetField("TextVilleCpClient", villeCpClient);
                formFields.SetField("TextTelephoneClient", telephoneClient);
                formFields.SetField("TextDesignationTypeAchat", typeAchat);
                formFields.SetField("TextDesignationLivreur", livreur);
                formFields.SetField("TextDesignationDateLivraisonCommande", dateLivraisonEstimer);

                formFields.SetField("TextTaxFacture", taxFacture + "%");

                float prixTotalHt = 0;

                int i = 1;
                foreach (var ligneCommande in dicLigneCommande)
                {
                    int refProduit = ligneCommande.Value.Item1;
                    DataRow leProduit = GestionProduit.getProduitById(refProduit);
                    string descriptionProduit = "Produit" + i;
                    int qteProduit = ligneCommande.Value.Item2;
                    float prixProduit = Convert.ToSingle(leProduit[2]);

                    //string totalLigneProduit = Convert.ToString(prixProduit * qteProduit);
                    formFields.SetField("TextRefProduitN" + i, Convert.ToString(refProduit));
                    formFields.SetField("TextDescriptionProduitN" + i, leProduit[1].ToString());
                    formFields.SetField("TextQteProduitN" + i, Convert.ToString(qteProduit));
                    formFields.SetField("TextPrixUnitaireProduitN" + i, Convert.ToString(prixProduit) + "$");
                    formFields.SetField("TextTotalLigneProduitN" + i, Convert.ToString(prixProduit * qteProduit) + "$");
                    prixTotalHt += prixProduit * qteProduit;
                    i++;
                }

                float dixPourcent = 1.10f;
                float quinzePourcent = 1.15f;
                float vintPourcent = 1.20f;
                float prixTTC = 0;


                formFields.SetField("TextTotalHorsTaxFacture", Convert.ToString(prixTotalHt) + "$");

                if(Convert.ToInt32(taxFacture) == 10)
                {
                    prixTTC = prixTotalHt * dixPourcent;
                } else {
                    if (Convert.ToInt32(taxFacture) == 15) {
                        prixTTC = prixTotalHt * quinzePourcent;
                    } else {
                        prixTTC = prixTotalHt * vintPourcent;
                    }
                }

                formFields.SetField("TextTotalMontentTax", Convert.ToString(prixTTC - prixTotalHt)+"$");

                formFields.SetField("TextTotalToutTaxCompriseFacture", Convert.ToString(prixTTC) + "$");

                // Fermer le tampon et le lecteur PDF
                stamper.Close();
                pdfReader.Close();
            }
        }
    }
}
