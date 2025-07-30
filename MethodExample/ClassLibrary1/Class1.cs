public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor

    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    //set methoda for attributes

    public void SetProductID(int value) { productID = value;}
    public void SetProductName(string value) { productName = value; }
    public void SetCost(double value) { cost = value;}
    public void SetTax(double value) { tax = value; }
    public void SetQuantityInStock(int value) { quantityInStock = value; }

    //get method for attributes
    public int GetProductID(){return productID;}
    public string GetProductname() { return productName;}
    public double GetCost() { return cost; }
    public double GetTax() { return tax; }
    public int GetQuantityInStock() { return quantityInStock; }


    //method

    /*cost <=20,000 then tax = 10%
     cost > 20,000 then tax = 12.5%
    */
    public void CalculateTax()
    {
        //create local variable
        double t;
        //calculate tax
        if (cost <= 20000)
        {
            t = cost * .10;
        }else
        {
            t = cost* .125; 
        }
        tax = t;
    }


}