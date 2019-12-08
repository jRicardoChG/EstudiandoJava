// se desea que mis modulos dependen lo menos posible de otro modulos en mi aplciacion
// PRINCIPIO DE SEGRERGACION DE INTERFACES
// interfaces tan pequeñas como sea posible
// PROBLEMA: que pasa si por ejemplo tenemos una herarquia de clases, tenemos una clase madre que indica los metodos que deben usar sus clases hijas, pero tengo clases hijas que no reuqieren implmentar todos esos metodos
// con clases abstractas este problema no se puede arreglar, dado uqe la clase madre abstracta pide que sus metodos sean definidos por sus clases hijas.
// Las clases hijas solo pueden heredar de esta clase madre
// asi que Tocaria definir los metodos sobrantes para estas clases hijas? generar codigo basura apra que el programa compile? no.
// El mismo problema pasa con interfaces muy grandes. las interfaces pioden implmentar varios emtodos, pero no todas las clases que implementan esta interface los requieren.
// ASI que el principio de segregacion d eitnerfaces hace es que se creen interfaces tanpequeñas como sea posible, y como las clases pueden implmeentar muchas itnerfaces
// No habra problema en poner todas las interfaces requeridas para esta clase, y que otras clases requieran menos interfaces.

// a continuacion se muestra el problema de la clase abstracta JAVA

public class Main
{
	public static void main(String[] args) {
		System.out.println("Hello World");
        Melones melon = new Melones("grande","amarillo");
        melon.imprimirColor();
        System.out.println(melon.getColor());
        Mangos mango = new Mangos("pequeño","amarilloRojo"); 
        System.out.println("imprimo el tamano de mango: " + mango.getTamano());
        System.out.println("imprimo el color de mango: " + mango.getColor());
	}
}


// toda clase que tenga un metodo abstract debe definirse como clase abstracta
abstract class Frutas
{
    protected String tamano; // propeidades protected para poder ser heredadas por clases hijas
    protected String color;
    protected abstract String getColor(); // puedo poner diferentes modificadores de acceso en los emtodos de la clase abstracta
    protected abstract void setColor(String color);
    public abstract String getTamano();
    public abstract void setTamano(String tamano);
    
    public void imprimirTamano()
    {
        System.out.println("El tamano de la fruta es:" + this.tamano);
    }
}

// la clase melones debe definir todos los metodos abstractos de la clase madre y sol puede heredar de la clase madre Frutas
class Melones extends Frutas
{
    public Melones(String tamano,String color)
    {
        this.tamano = tamano;
        this.color = color;
    }
    public Melones(){}
    
    @Override
    public String getTamano()
    {
        return this.tamano;
    }
    @Override
    public void setTamano(String tamano)
    {
        this.tamano = tamano;
    }
    
    @Override
    public String getColor()
    {
        return this.color;
    }
    @Override
    public void setColor(String color)
    {
        this.color = color;
    }
    
}

// ejemplo con interfaces
// las interfaces son iguales a las clases abstractas, pero una clase que la implemente puede usar cuantas interfaces quiera
// todos los metodos de la interface son publicos, enl a clase abstracta lo puedo definir a conveniencia
// tambien se puede hacer herencia entre interfaces

abstract class Frutas 
{
    protected String color;
    protected String tamano;
    
    public void imprimirColor()
    {
        System.out.println("El color es: "+ this.color);
    }
}

// segrego el codigo en interfaces pequeñas y hago mas flexible mi software
interface IColor
{
    void setColor(String Color);
    String getColor();
}

interface ITamano
{
    void setTamano(String Tamano);
    String getTamano();
}

// melones solo necesita implemntar IColor
class Melones extends Frutas implements IColor
{
    public Melones()
    {}

    public Melones(String color,String tamano)
    {
        this.tamano = tamano;
        this.color = color;
    }

    @Override
    public void setColor(String color)
    {
        this.color = color;
    }
    
    @Override
    public String getColor()
    {
        return this.color;
    }
}

// Mangos requiere implmentar Icolor y ITamano, como siempre todo lo de los dos contratos debe ser implementado
class Mangos extends Frutas implements IColor,ITamano
{
    public Mangos()
    {}
    public Mangos(String tamano,String color)
    {
        this.color = color;
        this.tamano = tamano;
    }

    @Override
    public void setColor(String color)
    {
        this.color = color;
    }
    
    @Override
    public String getColor()
    {
        return this.color;
    }

    @Override
    public void setTamano(String tamano)
    {
        this.color = color;
    }
    
    @Override
    public String getTamano()
    {
        return this.tamano;
    }

}


