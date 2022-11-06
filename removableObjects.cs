using Raylib_cs;

class Gem: Removable {
    
    public Gem() {
        pointValue = 1;
        aperance = "*";
        rectangle = new Rectangle(position.X, position.Y, 15, 15);
    }

    public override void Draw() {
        Raylib.DrawText(aperance, (int)position.X, (int)position.Y, 15, Color.BROWN);
    }
}

class Rock: Removable {

    public Rock() {
        pointValue = -1;
        aperance = "w";
        rectangle = new Rectangle(position.X, position.Y, 15, 15);
    }

    public override void Draw() {
        Raylib.DrawText(aperance, (int)position.X, (int)position.Y, 15, Color.PINK);
    }
    
}

class BigGem: Removable {

    public BigGem() {
        pointValue = 5;
        aperance = "<>";
        rectangle = new Rectangle(position.X, position.Y, 18, 18);
    }

    public override void Draw() {
        Raylib.DrawText(aperance, (int)position.X, (int)position.Y, 18, Color.PURPLE);
    }
    
}

class BigRock: Removable {

    public BigRock() {
        pointValue = -3;
        aperance = "(  )";
        rectangle = new Rectangle(position.X, position.Y, 20, 20);
    }

    public override void Draw() {
        Raylib.DrawText(aperance, (int)position.X, (int)position.Y, 20, Color.WHITE);
    }
    
}