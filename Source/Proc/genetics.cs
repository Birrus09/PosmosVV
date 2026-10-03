//for future simulation of life on habitable planets



using System.Collections.Generic;
namespace PosmosVV.Proc
{

    public class Gene
    {
        public char[] GenCode = new char[2];

        public void Mutate()
        {
            //add xor with random power of 2
            GenCode[0] = GenCode[0];
        }

    }

    public class Being
    {
        public Gene[] Genes;
        public int ID = 0;
        public int GeneLength = 4;

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

        public static Being Bisexual_Reproduction(Being Father, Being Mother, ref int seed)
        {
            if (Father.ID == Mother.ID)
            {
                Being b = new Being();
                b.ID = Father.ID;
                for (int i = 0; i < Father.Genes.Length; i++)
                {
                    b.Genes[i] = new Gene();
                    if (RandomGen.Chance(0.5f, ref seed))
                    {
                        b.Genes[i].GenCode[0] = Father.Genes[i].GenCode[0];
                    }
                    else
                    {
                        b.Genes[i].GenCode[0] = Mother.Genes[i].GenCode[0];
                    }
                    if (RandomGen.Chance(0.5f, ref seed))
                    {
                        b.Genes[i].GenCode[1] = Father.Genes[i].GenCode[1];
                    }
                    else
                    {
                        b.Genes[i].GenCode[1] = Mother.Genes[i].GenCode[1];
                    }
                }
                return b;
            }
            else
            {
                return null;
            }
            

        }

    }

}
