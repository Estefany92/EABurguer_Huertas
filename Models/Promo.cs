namespace EABurguer_Huertas.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string? Description { get; set; }
        public DateTime FechaPromo{ get; set; }

        //establece conexion tabla promo a bruguer
        public int BurgerID { get; set; }
        public Burger? Burger { get; set; }
    }
}
