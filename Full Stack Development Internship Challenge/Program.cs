using Full_Stack_Development_Internship_Challenge.Classes;

namespace Full_Stack_Development_Internship_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cheese = new Cheese("Cheese", 100, 5, DateTime.Now.AddDays(2), 0.4);
            var biscuits = new Biscuits("Biscuits", 150, 3, DateTime.Now.AddDays(3), 0.7);
            var scratchCard = new ScratchCard("ScratchCard", 50, 10);

            var customer = new Customer("Omar", 1000);
            var cart = new Cart();

            cart.Add(cheese, 2);
            cart.Add(biscuits, 1);
            //cart.Add(scratchCard, 1);

            CheckoutService.Checkout(customer, cart);

        }
    }
}
