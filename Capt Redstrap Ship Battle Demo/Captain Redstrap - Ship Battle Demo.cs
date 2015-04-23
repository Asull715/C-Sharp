using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* 
 * Captain Red-strap - Rough draft V0.1
 * 
 * Ship battle testing grounds to balance the games background math: stat's, levelling, enemy difficulty, and player skills.
 * 
 * Vision of the Final Product:
 * Captain Red-strap and the Impossible Journey will be a graphical 2D ship battle role playing mobile game staring the Infamous Capitan Red-strap 
 * and his deadly journeys through uncharted sea's! Your endeavour begins at the pirate haven, Big Bertha's Isle, and continues into unknown lands; 
 * all while collecting unseen treasures, recruiting new shipmates with new powers and skills, navigating through the dense story line, and, 
 * (MOST IMPORTANTLY!) triumphing trough hordes of encountered foes!  The Legends and Truths of Capitan Red-strap will one day strike fear 
 * in the hearts of even the most battle hungry warriors! 
 * 
 * Explanation and reason for the demo:
 * The current version of the Battle Demo is text based (Click and Read) strategy game. This demo is the testing ground for all mathematical events 
 * in the game: (Success/Failure %'s, damage amount's, crew loses, etc.). The text window serves and your eyes and ears; a fight announcer, if you will. 
 * Battle results will appear in the text output window.
 * 
 * UI stat's:
 * The player ship stat's are on the left, enemy's on the right. The player makes the first move by selecting any of the action buttons in GREEN.
 * After selecting an action, the text screen will display the results of your action, ALONG WITH, the enemy's action and result. 
 * Each player's action will be calculated and the stat's adjusted, while also triggering the enemy AI to strategize and take action as well.
 * To simplify, when an action button is selected, the action's results and the enemy's response/results will be displayed immediately.
 * 
 * Instructions:
 * (Select an action button to start the battle)
 * Both ships have equal stat's. When a ships heath falls below 1, the ship is sunk. 
 * Ideally, the player should plunder the enemy's ship to gain loot, supplies, and replenish lost crew members with enemy's willing to change sides.
 * 
 * Clicking a game button will trigger the action and the AI will take action automatically. The results of the exchange, Player and Enemy actions, 
 * will be displayed. Players can review the summary and select their next action to continue the battle.
 *  
 * In the full version, player's will face off against multiple enemy's before returning to port. 
 * The crew is the only way of being repaired between and during battle so keeping them alive and replacing lost crew is the only way to survive.
 * 
 * Buttons:
 * (Attack): Each ship has 4 side facing main attack cannons, each able to do 1 damage and possibly kill enemy crew members. All fire at once. 
 * (Repair): Crew members repair the ship based on how many crew are left, low crew mean low repairs and no plundering.
 * (Evade):  Ships also have 1 rear cannon. Evading will turn your ship away from the enemy and attack with the rear cannon. If the enemy fires back, 
 *           they are more likely to miss and the back of your ship will protect your crew from taking a hit! (No crew is lost when evading) 
 * (Plunder):To plunder a ship, the enemy's crew must be under %20 and the players crew, above %20. Plunder success is %50.
 *           The plunder button will change to GREEN when it is available.
 */

namespace Capt_Redstrap_Ship_Battle_Demo
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
            Battle_Start();
            Replay_Button.Hide();
        }
       
        //Creat instance of Myship and Enemyship, giving access to the 2 classes property's
        MyShip_ClassFile myShip = new MyShip_ClassFile();
        EnemyShip_ClassFile enShip = new EnemyShip_ClassFile();
            
        public void Battle_Start()
        {
            //Set variable's values to generic 1st level battle
            myShip.Agility = 1;
            myShip.Attack = 1;
            myShip.Crew = 25;
            myShip.Health = 30;

            enShip.Agility = 1;
            enShip.Attack = 1;
            enShip.Crew = 25;
            enShip.Health = 30;

            //Update GUI labels to current ship/enemy stat's
            Battle_Update();

            //Display instuctions
            SummaryBox.AppendText("(Select an action button to start the battle)\n");
            SummaryBox.AppendText("Both ships have equal stat's. When a ships heath falls below 1, the ship is sunk.\n");
            SummaryBox.AppendText("Ideally, the player should plunder the enemy's ship to gain loot, supplies, and\n");
            SummaryBox.AppendText("replenish lost crew members with enemy's willing to change sides.\n");
            SummaryBox.AppendText("\n");
            SummaryBox.AppendText("Clicking a game button will trigger the action and the AI will take action automatically. The results of the exchange, Player and Enemy actions, will be displayed. Players can review the summary and select their next action to continue the battle. \n\nIn the full version, player's will face off against multiple enemy's before returning to port. The crew is the only way of being repaired between and during battle so keeping them alive and replacing lost crew is the only way to survive.\n");
            SummaryBox.AppendText("\n");
            SummaryBox.AppendText("Buttons:\n");
            SummaryBox.AppendText("\n");
            SummaryBox.AppendText("(Attack): Each ship has 4 side facing main attack cannons, each able to do 1 dmg and possibly kill enemy crew members. All fire at once. \n");
            SummaryBox.AppendText("\n");
            SummaryBox.AppendText("(Repair): Crew members repair the ship based on how many crew are left, low crew mean low repairs and no pludering.\n");
            SummaryBox.AppendText("\n");
            SummaryBox.AppendText("(Evade):  Ships also have rear cannon. Evading will turn your ship away from the enemy and attack with the rear cannon. If the enemy fires back, they are more likly to miss and the back of your ship will protect your crew from taking a hit! (No crew is lost when evading) \n");
            SummaryBox.AppendText("\n");
            SummaryBox.AppendText("(Plunder):To plunder a ship, the enemy's crew must be under %20 and the players crew, above %20. Plunder success is %50. The plunder button will change to GREEN when it is availible.\n");
        }

        public void Battle_Update()
        {
            //Update GUI's label's to current ship/enemy stat's
            Ship_Agility.Text = myShip.Agility.ToString();
            Ship_Attack.Text = myShip.Attack.ToString();
            Ship_Crew.Text = myShip.Crew.ToString();
            Ship_Health.Text = myShip.Health.ToString();
            Enemy_Agility.Text = enShip.Agility.ToString();
            Enemy_Attack.Text = enShip.Attack.ToString();
            Enemy_Crew.Text = enShip.Crew.ToString();
            Enemy_Health.Text = enShip.Health.ToString();

            //Check Button Colors
            //Plunder (other ship must be under 20% crew and you must be over 20% crew)
            if (enShip.Crew > 6) { Plunder_Button.ForeColor = Color.Red; }
            else 
            {
                Plunder_Button.ForeColor = Color.Green; 
             
                if (myShip.Crew < 7) 
                { 
                    Plunder_Button.ForeColor = Color.Red; 
                }
            }
            
            //Repair
            if (myShip.Health <= 29) { Repair_Button.ForeColor = Color.Green; }
            else { Repair_Button.ForeColor = Color.Red; }

        }

        private void Plunder()
        {
            SummaryBox.Clear();
            if (enShip.Crew < 7) // plunder is only possible if enemy crew is %20 or under AND you have at least 20 percent of your crew
            {
                if (myShip.Crew > 5)
                {
                    Random plunderChance = new Random();
                    int plunderSuccess = plunderChance.Next(2); // %50 chance : random num(0-1)
                    if (plunderSuccess == 1)
                    {
                        enShip.Health = 0;
                        SummaryBox.AppendText("Plunder Successful!!!!\n");
                        SummaryBox.AppendText("\n");
                    }
                    else
                    {
                        SummaryBox.AppendText("Though you they are weakened, the enemy resisted your attempt.\n");
                        SummaryBox.AppendText("\n");
                    }
                }
            }
            else
            {
                SummaryBox.AppendText("They are to strong!, the enemy resisted your attempt. Wait till more enemy crew is destroyed.\n");
                SummaryBox.AppendText("\n");
            }

        }  

        private void RepairShip()
        {
            //Check if ship needs repair
            if (myShip.Health < 30)
            {
                if (myShip.Crew > 0)
                {
                    Random crewMemberNum = new Random();
                    int crewMemberSuccessRan = crewMemberNum.Next(myShip.Crew + 1); //Random number between 0 and # of current living crew memebers
                    int crewMemberSuccess = crewMemberNum.Next(crewMemberSuccessRan + 1); //Takes crewMemberSuccessRan to make the range of the random ammout fo crew members success full (Half ass way of making 50% of 50%)

                    myShip.Health = myShip.Health + crewMemberSuccess;

                    if (crewMemberSuccess > 0)
                    {
                        SummaryBox.AppendText("The crew was able to repair some of the ship\n");
                        SummaryBox.AppendText(crewMemberSuccess + " health gained.\n");
                        SummaryBox.AppendText("\n");
                    }
                    else
                    {
                        SummaryBox.AppendText("The crew was unsuccessfull with repairing the ship.\n");
                        SummaryBox.AppendText(crewMemberSuccess + " health gained.\n");
                        SummaryBox.AppendText("\n");
                    }
                }
            }
            else
            {
                SummaryBox.AppendText("Your ship is fully repaired.\n");
                SummaryBox.AppendText("0 health gained.\n");
                SummaryBox.AppendText("\n");
            }
        }
        

        private void ShipAttack()
        {
            Random cannonFire = new Random();
            
            //Variables for updating Summary Box
            int crewKilled = 0;
            int shipDmg = 0;
            SummaryBox.AppendText("Player:\n");
            SummaryBox.AppendText("Fire all cannons!\n");
            SummaryBox.AppendText("\n");
            SummaryBox.AppendText("Results:\n");
            //Cannon 1 fired
            int can1 = cannonFire.Next(2);
            if (can1 == 1) //Enemy Ship hit with Cannon 1
            {
                enShip.Health = enShip.Health - 1; //Damaged enemy ship by 1
                shipDmg = shipDmg + 1; // tracking update box message
                SummaryBox.AppendText("Cannon 1 Hit!\n");

                //Crew hit? 25 percent chance
                int crewHit = cannonFire.Next(4); //25% chance (0-3); 1=crew member hit  
                if (crewHit == 1) //Crew Hit
                {
                    enShip.Crew = enShip.Crew - 1; //Killed 1 enemy crew
                    crewKilled = crewKilled + 1;  // tracking update box message                   
                }
            }
            else { SummaryBox.AppendText("Cannon 1 Missed.\n"); }

            //Cannon 2 fired
            int can2 = cannonFire.Next(2);
            if (can2 == 1) //Enemy Ship hit with Cannon 2
            {
                enShip.Health = enShip.Health - 1; //Damaged enemy ship by 1
                shipDmg = shipDmg + 1; // tracking update box message
                SummaryBox.AppendText("Cannon 2 Hit!\n");

                //Crew hit? 25 percent chance
                int crewHit = cannonFire.Next(4); //25% chance (0-3); 1=crew member hit 
                if (crewHit == 1) //Crew Hit
                {
                    enShip.Crew = enShip.Crew - 1; //Killed 1 enemy crew
                    crewKilled = crewKilled + 1;  // tracking update box message                   
                }
            }
            else { SummaryBox.AppendText("Cannon 2 Missed.\n"); }

            //Cannon 3 fired
            int can3 = cannonFire.Next(2);
            if (can3 == 1) //Enemy Ship hit with Cannon 3
            {
                enShip.Health = enShip.Health - 1; //Damaged enemy ship by 1
                shipDmg = shipDmg + 1; // tracking update box message
                SummaryBox.AppendText("Cannon 3 Hit!\n");

                //Crew hit? 25 percent chance
                int crewHit = cannonFire.Next(4); //25% chance (0-3); 1=crew member hit  
                if (crewHit == 1) //Crew Hit
                {
                    enShip.Crew = enShip.Crew - 1; //Killed 1 enemy crew
                    crewKilled = crewKilled + 1;  // tracking update box message                   
                }
            }
            else { SummaryBox.AppendText("Cannon 3 Missed.\n"); }

            //Cannon 4 fired
            int can4 = cannonFire.Next(2);
            if (can4 == 1) //Enemy Ship hit with Cannon 4
            {
                enShip.Health = enShip.Health - 1; //Damaged enemy ship by 1
                shipDmg = shipDmg + 1; // tracking update box message
                SummaryBox.AppendText("Cannon 4 Hit!\n");

                //Crew hit? 25 percent chance
                int crewHit = cannonFire.Next(4); //25% chance (0-3); 1=crew member hit  
                if (crewHit == 1) //Crew Hit
                {
                    enShip.Crew = enShip.Crew - 1; //Killed 1 enemy crew
                    crewKilled = crewKilled + 1;  // tracking update box message                   
                }
            }
            else { SummaryBox.AppendText("Cannon 4 Missed.\n"); }

            //Only annouce crew members killed if any died.
            if (crewKilled > 0)
            {
                SummaryBox.AppendText("Enemy ship took " + shipDmg.ToString() + " DMG and lost " + crewKilled + " crew members!\n");
                SummaryBox.AppendText("\n");
            }
            else
            {
                SummaryBox.AppendText("Enemy ship took " + shipDmg.ToString() + " DMG!\n");
                SummaryBox.AppendText("\n");
            }
        }


        private void ShipEvade()
        {
            //
            //Evading part
            //
            Random enemyFire = new Random();
            int enemyHit = enemyFire.Next(5);
            int successfulHit = enemyFire.Next(enemyHit);

            myShip.Health = myShip.Health - successfulHit;

            SummaryBox.AppendText("Enemy:\n");
            SummaryBox.AppendText("The enemy attacks as anticipated!\n");
            SummaryBox.AppendText("You turn to evade!\n");         
            SummaryBox.AppendText("\n");

            //
            //Reverse Cannon
            //

            Random cannonFire = new Random();

            //Variables for updating Summary Box
            int crewKilled = 0;
            int shipDmg = 0;

            //Cannon 1 fired
            SummaryBox.AppendText("Result:\n");
            SummaryBox.AppendText("The enemy attack caused " + successfulHit.ToString() + " dmg.\n");
            SummaryBox.AppendText("\n");
            int can1 = cannonFire.Next(2);
            if (can1 == 1) //Enemy Ship hit with Cannon 1
            {
                enShip.Health = enShip.Health - 1; //Damaged enemy ship by 1
                shipDmg = shipDmg + 1; // tracking update box message
                SummaryBox.AppendText("Your Rear Cannon Hit!\n");

                //Crew hit? 25 percent chance
                int crewHit = cannonFire.Next(4); //25% chance (0-3); 1=crew member hit  
                if (crewHit == 1) //Crew Hit
                {
                    enShip.Crew = enShip.Crew - 1; //Killed 1 enemy crew
                    crewKilled = crewKilled + 1;  // tracking update box message                   
                }
            }
            else { SummaryBox.AppendText("Your Rear Cannon Missed.\n"); }

            //Only annouce crew members killed if any died.
            if (crewKilled > 0)
            {
                SummaryBox.AppendText("Enemy ship took " + shipDmg.ToString() + " DMG and lost " + crewKilled + " crew members!\n");
                SummaryBox.AppendText("\n");
            }
            else
            {
                SummaryBox.AppendText("Enemy ship took " + shipDmg.ToString() + " DMG!\n");
                SummaryBox.AppendText("\n");
            }
        }

        private void Attack_Button_Click(object sender, EventArgs e)
        {
            SummaryBox.Clear();
            ShipAttack();
            Battle_Update();
            EnemyAI();
            Battle_Update();
            CheckIfGameOver();
        }

        private void Evade_Button_Click(object sender, EventArgs e)
        {
            SummaryBox.Clear();
            ShipEvade();
            Battle_Update();
            CheckIfGameOver();
        }
        
        private void Repair_Button_Click(object sender, EventArgs e)
        {
            SummaryBox.Clear();
            RepairShip();
            Battle_Update();
            EnemyAI();
            Battle_Update();
            CheckIfGameOver();
        }

        private void Plunder_Button_Click(object sender, EventArgs e)
        {
            SummaryBox.Clear();
            Plunder();
            CheckIfGameOver();
            Battle_Update();
            EnemyAI();
            Battle_Update();
            
        }

        private void CheckIfGameOver()
        {
            if (enShip.Health < 1)
            {
                SummaryBox.AppendText("You are VICTORIOUS!!!!");
                Replay_Button.Visible = true;


                Attack_Button.Hide();
                Repair_Button.Hide();
                Plunder_Button.Hide();
                Evade_Button.Hide();
            }
            if (myShip.Health < 1)
            {
                SummaryBox.AppendText("YOUR SHIP IS SINKING!!!!");
                Replay_Button.Visible = true;


                Attack_Button.Hide();
                Repair_Button.Hide();
                Plunder_Button.Hide();
                Evade_Button.Hide();
            }

        }

        //
        //ENEMY AI STUFF
        //


        private void EnemyAI()
        {
            //
            //Enemy Decision: Attack or Repair (Always attacks unless: Below 60% health, 50% chance they repair. Below 15% health, 90% chance they repair.)
            //
            if (enShip.Health < 19) // 60 percent
            {
                Random fiftyChance = new Random();
                int fiftyChanceRep = fiftyChance.Next(2); //0-1
                if (fiftyChanceRep == 1)
                {
                    EnemyRepair();
                }
                else
                {
                    EnemyAttack();
                }
            }
            else if (enShip.Health < 5) // 15 percent
            {
                Random fifteenChance = new Random();
                int fifteenChanceRep = fifteenChance.Next(10); //0-9
                if (fifteenChanceRep < 0) // 90 percent chance
                {
                    EnemyRepair();
                }
                else
                {
                    EnemyAttack();
                }
            }
            else
            {
                EnemyAttack();
            }
        }

        private void EnemyRepair()
        {
            if (enShip.Health <= 0)
            {
                if (enShip.Crew > 0)
                {
                    Random crewMemberNum = new Random();
                    int crewMemberSuccessRan = crewMemberNum.Next(enShip.Crew + 1); //Random number between 0 and # of current living crew memebers
                    int crewMemberSuccess = crewMemberNum.Next(crewMemberSuccessRan + 1); //Takes crewMemberSuccessRan to make the range of the random ammout fo crew members success full (Half ass way of making 50% of 50%)

                    enShip.Health = enShip.Health + crewMemberSuccess;

                    if (crewMemberSuccess > 0)
                    {
                        SummaryBox.AppendText("The Enemy Repaired:\n");
                        SummaryBox.AppendText("Repaired for " + crewMemberSuccess);
                        SummaryBox.AppendText("\n");
                    }
                    else
                    {
                        SummaryBox.AppendText("The enemy tried to repair their ship. They were not successful.\n");
                        SummaryBox.AppendText("\n");
                    }
                }
                else
                {
                    SummaryBox.AppendText("The enemy tried to repair their ship. They were not successful.\n");
                    SummaryBox.AppendText("\n");
                }
            }
        }

 	    private void EnemyAttack()
        {

            SummaryBox.AppendText("The Enemy Attacked with their 4 side facing cannons!:\n");
            SummaryBox.AppendText("\n");

         Random cannonFire = new Random();
            
            //Variables for updating Summary Box
            int crewKilled = 0;
            int shipDmg = 0;

            //Cannon 1 fired
            int can1 = cannonFire.Next(2);
            if (can1 == 1) //Enemy Ship hit with Cannon 1
            {
                myShip.Health = myShip.Health - 1; //Damaged enemy ship by 1
                shipDmg = shipDmg + 1; // tracking update box message

                //Crew hit? 25 percent chance
                int crewHit = cannonFire.Next(4); //25% chance (0-3); 1=crew member hit  
                if (crewHit == 1) //Crew Hit
                {
                    myShip.Crew = myShip.Crew - 1; //Killed 1 of my crew
                    crewKilled = crewKilled + 1;  // tracking update box message                   
                }
            }

            //Cannon 2 fired
            int can2 = cannonFire.Next(2);
            if (can2 == 1) //Enemy Ship hit with Cannon 2
            {
                myShip.Health = myShip.Health - 1; //Damaged enemy ship by 1
                shipDmg = shipDmg + 1; // tracking update box message

                //Crew hit? 25 percent chance
                int crewHit = cannonFire.Next(4); //25% chance (0-3); 1=crew member hit  
                if (crewHit == 1) //Crew Hit
                {
                    myShip.Crew = myShip.Crew - 1; //Killed 1 of my crew
                    crewKilled = crewKilled + 1;  // tracking update box message                   
                }
            }

            //Cannon 3 fired
            int can3 = cannonFire.Next(2);
            if (can3 == 1) //Enemy Ship hit with Cannon 3
              {
                myShip.Health = myShip.Health - 1; //Damaged enemy ship by 1
                shipDmg = shipDmg + 1; // tracking update box message

                //Crew hit? 25 percent chance
                int crewHit = cannonFire.Next(4); //25% chance (0-3); 1=crew member hit  
                if (crewHit == 1) //Crew Hit
                {
                    myShip.Crew = myShip.Crew - 1; //Killed 1 of my crew
                    crewKilled = crewKilled + 1;  // tracking update box message                   
                }
            }

            //Cannon 4 fired
            int can4 = cannonFire.Next(2);
            if (can4 == 1) //Enemy Ship hit with Cannon 4
            {
                myShip.Health = myShip.Health - 1; //Damaged enemy ship by 1
                shipDmg = shipDmg + 1; // tracking update box message

                //Crew hit? 25 percent chance
                int crewHit = cannonFire.Next(4); //25% chance (0-3); 1=crew member hit  
                if (crewHit == 1) //Crew Hit
                {
                    myShip.Crew = myShip.Crew - 1; //Killed 1 of my crew
                    crewKilled = crewKilled + 1;  // tracking update box message                   
                }
            }

            
            //Only annouce crew members killed if any died.
            if (crewKilled > 0)
            {
                SummaryBox.AppendText("Your ship took " + shipDmg.ToString() + " DMG and lost " + crewKilled + " crew members!\n");
                SummaryBox.AppendText("\n");
            }
            else
            {
                SummaryBox.AppendText("Your ship took " + shipDmg.ToString() + " DMG!\n");
                SummaryBox.AppendText("\n");
            }
        }

        private void Replay_Button_Click(object sender, EventArgs e)
        {
            SummaryBox.Clear();
            Battle_Start();
            Battle_Update();
            Replay_Button.Hide();
            Attack_Button.Visible = true;
            Repair_Button.Visible = true;
            Plunder_Button.Visible = true;
            Evade_Button.Visible = true;
        }
   
    }
}
