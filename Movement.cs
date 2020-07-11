//After creating a c# file for the sprite, insert this code for it to move under => void update ()    
    float x = Input.GetAxis ("Horizontal") * Time.deltaTime * 40; 
    float y = Input.GetAxis ("Vertical") * Time.deltaTime * 40;

    transform.Translate (x , y, 0);
