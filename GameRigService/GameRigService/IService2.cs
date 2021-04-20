using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GameRigService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        int AddMember(User u);

        [OperationContract]
        int getProId(string name);


        [OperationContract]
        int AddSubscriber(NewsLetter Nlet);

        [OperationContract]
         int Login(String EmailS, String PassWordS);

        [OperationContract]
        int AddNewProduct(string ProductName, int ProductPrice, string Colour, string Quantity, string type, string Description, string image);

        [OperationContract]
        int SearchProduct(int id);

        [OperationContract]
        bool EditProduct(AddProduct add, int Id);
        [OperationContract]
        int DeleteProduct(int id);
        [OperationContract]
        AddProduct GetProduct(int id);

        [OperationContract]
        int DeleteUser( string email);

        [OperationContract]
        User GetUser(int ID);

        [OperationContract]
        bool Registerd(string email, string password);
        [OperationContract]
        List<ProductTable> searchProducts(string name);

        [OperationContract]
        List<ProductTable> getAllProducts();
        [OperationContract]
        List<ProductTable> getAllFpProducts();
        [OperationContract]
        List<ProductTable> getAllFnProducts();
       
      

    }
}
