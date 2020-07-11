
//After creating a c# file for the sprite, insert this code for it to move under => void update ()    
    float runSpeed = 40f;    
    float x = Input.GetAxis ("Horizontal") * Time.deltaTime * runSpeed; 
    float y = Input.GetAxis ("Vertical") * Time.deltaTime * runSpeed;

    transform.Translate (x , y, 0);
