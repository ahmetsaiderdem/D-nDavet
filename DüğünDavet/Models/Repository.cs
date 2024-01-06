namespace DüğünDavet.Models
{
    public class Repository
    {
        private static List<Cevap> cevaps = new List<Cevap>();
        public static IEnumerable<Cevap> cevaplar => cevaps;
        public static void CevapEkle(Cevap cevapp)
        {
            cevaps.Add(cevapp);
        }
    }
}
