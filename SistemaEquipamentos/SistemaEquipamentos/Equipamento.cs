namespace SistemaEquipamentos {
    internal class Equipamento {

        public int Codigo {  get; set; }
        public string Nome {  get; set; }
        public int Serie { get; set; }
        public string Defeito {  get; set; }

        public Equipamento(int code, string name, int serie) { 
            Codigo = code;
            Nome = name;
            Serie = serie;
        }
        public Equipamento(int code, string name, int serie, string bad):this(code, name, serie) { 
            Defeito = bad;
        }

        public void AtualizarDefeito(string newBad) {
            Defeito = newBad;
        }

        public override string ToString() {
            return Codigo
                +"  |   "
                +Nome
                +", "
                +Serie
                +"  |   "
                +Defeito;
        }
    }
}
