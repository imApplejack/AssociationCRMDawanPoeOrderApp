using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Service;

namespace OrderForm
{
    /*Boisson : Cola, limonade, eau
     *Plat: Kebab, galette, tacos
     *Accompagnement: Frites, semoule
    */


    public partial class Form1 : Form
    {
        public ProductServiceImpl productService =new();
        public List<Product> listProduits = new();
        public List<string> listCat = new();
        public double totalOrder = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Demander un ID d'order
            // Creer une order

            //listCat = productService.GetAllCategory();
            listProduits = productService.getAllProduct();
                                
            
            foreach (string item in listCat)
            {
                ListCategory.Items.Add(item);
            }




        }
        private void ListCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListProduit.Items.Clear();
            if (ListCategory.SelectedItem is not null)
            {
                foreach (Product item in listProduits)
                {
                    if (item.ProductCategory.ToString() == ListCategory.SelectedItem.ToString())
                    {
                        ListProduit.Items.Add(item.Name);
                    }
                }
            }
        }

        private void ListProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListProduit.SelectedItem is not null)
            {
                string str = (string)ListProduit.SelectedItem;
                Product pdt = listProduits.FindAll(x => x.Name == str).FirstOrDefault();
                //LOrsqu'on clique sur un produit de la liste, il s'affiche dans la listOrder
                listOrder.Items.Add($"{pdt.Name}        {pdt.Price}");

                //Chercher dans la table order en cours la somme des prix
                totalOrder += pdt.Price;
                
                
                

            }
        }

        //Bouton payer:
        //Appeler la fenêtre moyens de paiement


    }
}