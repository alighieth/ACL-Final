public class Knife
{   
    int durabilityPoints;


    public Knife() {
        this.durabilityPoints = 10;
    }

    public void use() {
        if(durabilityPoints == 0) return;
    }

    public void repair() {
        // if(playerGold < 10 ) return;
        this.durabilityPoints = 10;
        // deduct 10 gold points
    }

}