using System.Collections.Generic;
namespace PosmosVV.Proc
{


    public class Gamete
    {
        public char GenCode = (char)0xF0;
        public char HighLow = 'H'; // can be Low or High, during sexual reproduction two L and two H gamete combine to form two new Chromosomes (chars inside GenCode)
    }
    public class Gene
    {
        public char[] GenCode = new char[2]; //each char is a Chromosome

        public void Mutate()
        {
            //TODO: add xor with random power of 2
            GenCode[0] = (char)(GenCode[0] & 0x04);
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
            //Each chromosome in a gene splits and gives a gamete, one H and one L 
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
                g[1].GenCode = (char)(this.GenCode[1] & 0x0F);
            }
            else
            {
                g[1].GenCode = (char)((this.GenCode[1] & 0xF0) >> 4);
            }
            return g;
        }

    }

    public class Being
    {
        public Gene[] Genes;
        public int ID = 0;
        public int GeneLength = 4;
        public char sex = 'F'; //H is hermaphrodite
        public int age = 0;
        public bool Virtual = false; //artificial ins.
        public bool Haploid = false; //Females have 0x00 0xFF, Males have 0xFF 0x00
        public bool Diploid = false;
        public bool Egg = false;
        public void initialize_genes()
        {
            Genes = new Gene[GeneLength];
        }

        public char Fenotype(int geneindex)
        {
            //Fenotype is determined by the strongest chromosome, Genotype is determined by the whole gene
            if (Genes[geneindex].GenCode[0] > Genes[geneindex].GenCode[1])
            {
                return Genes[geneindex].GenCode[0];
            }
            else
            {
                return Genes[geneindex].GenCode[1];
            }
        }

        public char[] Genotype(int geneindex)
        {
            return Genes[geneindex].GenCode;
        }
    }



    public static class GenFunc
    {

        public static Being Clonation(Being Origin)
        {
            //N -> (N, N)
            Being r = new Being();
            r = Origin;
            r.age = 0;
            return r;
        }


        public static Being Sexual_Reproduction(Being Male, Being Female, ref int seed)
        {
            //M, F -> (M, F) 
            if (Male.ID == Female.ID)
            {
                var offspring = new Being();
                offspring.initialize_genes();

                if (!Male.Haploid && !Female.Diploid)
                {
                    for (int i = 0; i < Female.GeneLength; i++)
                    {
                        Gamete[] M_gams = Male.Genes[i].Meiosis(ref seed);
                        Gamete[] F_gams = Female.Genes[i].Meiosis(ref seed);
                        offspring.Genes[i].GenCode[0] = (char)(M_gams[0].GenCode | F_gams[1].GenCode);
                        offspring.Genes[i].GenCode[1] = (char)(M_gams[1].GenCode | F_gams[0].GenCode);
                    }
                }
                else
                {
                    offspring.Diploid = true;
                    for (int i = 0; i < Female.GeneLength; i++)
                    {
                        offspring.Genes[i].GenCode[0] = Male.Genes[i].GenCode[0];
                        offspring.Genes[i].GenCode[1] = Female.Genes[i].GenCode[1];
                    }
                }
                return offspring;
            }
            else
            {
                return null;
            }
        }

        public static Being Parthenogenesis(Being Parent, ref int seed)
        {
            Being offspring = new Being();
            offspring.initialize_genes();
            if (Parent.Haploid)
            {
                //male drones in haplodiploid species
                offspring = Clonation(Parent);
                offspring.Egg = true;
            }
            else
            {
                for (int i = 0; i < Parent.GeneLength; i++)
                {
                    offspring.Genes[i] = Parent.Genes[i].Mythosis();
                }
            }
            return offspring;
        }

        public static Being DiploidEgg(Being Queen, ref int seed)
        {
            if (Queen.Diploid == true)
            {
                Being offspring = new Being();
                offspring.initialize_genes();
                offspring.Haploid = true;
                offspring.Egg = true;
                offspring.sex = 'F';
                for (int i = 0; i <  Queen.GeneLength; i++)
                {
                    Gamete[] FemGam = Queen.Genes[i].Meiosis(ref seed);
                    offspring.Genes[i].GenCode[1] = (char)(FemGam[0].GenCode | FemGam[1].GenCode);
                }
                return offspring;
            }
            else return null;

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

        public static void Crispr(Being Subject, char Chromosome, int Geneindex, int Chromindex = 0)
        {
            if (Geneindex < Subject.GeneLength)
            {
                Subject.Genes[Geneindex].GenCode[Chromindex] = Chromosome;
            }
        }

    }

}
