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
        public ProductServiceMock productService = new();
        public List<Product> listProduits = new();
        public List<string> listCat = new();
        public double totalOrder = 0;

        //Creation d'une commande vide
        public Order currentOrder = new() { MenuState = OrderState.Payed };
        public int orderNumber = 0;


        public List<Order> sessionOrders = new();
        public Form1()
        {
            InitializeComponent();
            listProduits = productService.getAllProduct();
            listCat = productService.GetAllCategory();
            BindDatagrid();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Demander un ID d'order
            // Creer une order
            Bindall();

            textBoxOrderName.Text = $"{currentOrder.OrderName}";



        }

        private void Bindall()
        {
            // Ouverture d'une nouvelle commande lors du chargement/rechargement de la fenêtre
            //dataGridOrder.DataSource = currentOrder;


            if (currentOrder.MenuState == OrderState.Payed)
            {
                orderNumber += 1;
                currentOrder = NewOrder();
            }


            //Mise à jour de la listBox des categories
            foreach (string item in listCat)
            {
                ListCategory.Items.Add(item);
            }

        }
        public Order NewOrder()
        {
            Order order = new Order();
            order.OrderName = $"CMD #{orderNumber.ToString()}";
            order.MenuState = OrderState.Pending;
            return order;
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

                //<->
                currentOrder.AddProductToOrder(pdt);
                //listOrder.Items.Clear();
                //listOrder.Items.Add(pdt);

                //Chercher dans la table order en cours la somme des prix
                totalOrder = 0;
                foreach (Product item in currentOrder.Products)
                {
                    double i = item.Price;
                    totalOrder += i;
                }
                //totalOrder += pdt.Price;
                Order test = currentOrder;
                //dataGridOrder.DataSource = currentOrder;
                //dataGridOrder.DataSource = currentOrder.GetAllProducts();
                textBoxTotal.Text = totalOrder.ToString();
                /*dataGridOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;dataGridOrder.DataSource = currentOrder.GetAllProducts();
                dataGridOrder.Columns["id"].Visible= false;
                dataGridOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;*/
                //BindDatagrid();
                ListProduit.SelectedItem = 0;
            }
        }


        private void BindDatagrid()
        {

            Order ob = new Order();
            foreach(Product p in   currentOrder.GetAllProducts())
            {
                ob.AddProductToOrder(p);
            }

            dataGridOrder.DataSource = ob.GetAllProducts();
            dataGridOrder.Columns["id"].Visible = false;
            dataGridOrder.ReadOnly = true;
            dataGridOrder.Columns["Name"].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            dataGridOrder.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOrder.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOrder.Columns["Price"].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            dataGridOrder.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOrder.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void BtnPaiement_Click(object sender, EventArgs e)
        {
            /*int i = dataGridOrder.DisplayedRowCount(true);
            int j = dataGridOrder.DisplayedColumnCount(true);

            textBoxlignesvues.Text = i.ToString();
            textBoxlignescachees.Text = j.ToString();
            dataGridOrder.DataSource = currentOrder.GetAllProducts();
            dataGridOrder.Columns["id"].Visible= false;*/
            BindDatagrid();
        }

        //Bouton payer:
        //Appeler la fenêtre moyens de paiement

    }
}