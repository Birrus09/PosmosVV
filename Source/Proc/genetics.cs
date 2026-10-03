using System.Collections.Generic;
namespace PosmosVV.Proc
{


    public class Gamete
    {
        public char GenCode = (char)0xF0;
        public char HighLow = 'H';
    }
    public class Gene
    {
        public char[] GenCode = new char[2];

        public void Mutate()
        {
            //add xor with random power of 2
            GenCode[0] = GenCode[0];
        }

        public Gene Mythosis()
        {
            Gene g = new Gene();
            g.GenCode[0] = (char)((this.GenCode[0] & 0xF0) | (this.GenCode[1] & 0x0F));
            g.GenCode[1] = (char)((this.GenCode[1] & 0xF0) | (this.GenCode[0] & 0x0F));
            return g;
        }

        public Gamete[] Meiosis(ref int seed)
        {
            Gamete[] g = new Gamete[2];
            g[0] = new Gamete();
            g[0].HighLow = 'H';
            g[1] = new Gamete();
            g[1].HighLow = 'L';
            if (RandomGen.Chance(0.5f, ref seed))
            {
                g[0].GenCode = (char)(this.GenCode[0] & 0xF0);
            }
            else
            {
                g[0].GenCode = (char)((this.GenCode[0] & 0x0F) << 4);
            }
            if (RandomGen.Chance(0.5f, ref seed))
            {
                g[1].GenCode = (char)(this.GenCode[1] & 0xF0);
            }
            else
            {
                g[1].GenCode = (char)((this.GenCode[1] & 0x0F) << 4);
            }
            return g;
        }

    }

    public class Being
    {
        public Gene[] Genes;
        public int ID = 0;
        public int GeneLength = 4;
        public char sex = 'F';
        public int age = 0;
        public bool Virtual = false; //artificial ins.
        public void initialize_genes()
        {
            Genes = new Gene[GeneLength];
        }

        public char Fenotype(int geneindex)
        {
            if (Genes[geneindex].GenCode[0] > Genes[geneindex].GenCode[1])
            {
                return Genes[geneindex].GenCode[0];
            }
            else
            {
                return Genes[geneindex].GenCode[1];
            }
        }
    }



    public static class GenFunc
    {

        public static Being Clonation(Being Origin)
        {
            Being r = new Being();
            r = Origin;
            r.age = 0;
            return r;
        }


        public static Being Sexual_Reproduction(Being Male, Being Female, ref int seed)
        {
            //M, F -> (M, F)
            

        }

        public static Being Parthenogenesis(Being Female, ref int seed)
        {
            // F -> (F, F)            
        }
        public static Being Androgenesis(Being Female, Being Male, ref int seed)
        {
            //F + M-> (M, M)

        }

        public static Being Hybridogenesis(Being Female, Being Male, ref int seed)
        {
            //Ff1 + Mm2 -> (F, Mm) (lost gene, new species)
        }

        public static Being Eusocial_fertilization(Being Female, Being Male)
        {
            //F + M -> (FM, F), always female
        }

    }

}
