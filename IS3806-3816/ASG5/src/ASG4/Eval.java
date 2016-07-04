package ASG4;

import java.awt.*;
import java.awt.event.*;
import java.sql.*;
// import java.text.*;
import javax.swing.*;
import javax.swing.border.Border;
import javax.swing.border.LineBorder;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
// import javax.swing.event.*;
//import org.apache.derby.jdbc.*;
//import sun.jdbc.odbc.JdbcOdbcDriver;

public class Eval extends JFrame
{
   private JLabel teamLabel;
   private JComboBox teamComboBox;
   private JPanel teamPanel;

   private Connection myConnection; // instance variables used to manipulate database
   private Statement myStatement;
   private ResultSet myResultSet;
   
   JTextField avgResultText;
   JButton submitButton;
           
   /*private int js1Score;
   private int js2Score;
   private int js3Score;
   private int js4Score;*/
   private double avg;
    
    public static void main(String args[]) throws SQLException // execute application
    {
        JFrame f = new JFrame();
        f.setPreferredSize(new Dimension(500, 500));
        f.setResizable(false);

        String databaseDriver = "org.apache.derby.jdbc.ClientDriver"; 
        String databaseURL = "jdbc:derby://localhost:1527/Cool";
        
        Eval eval = new Eval(databaseDriver, databaseURL); // create new Eval
        eval.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
           
   public Eval(String databaseDriver, String databaseURL) throws SQLException // establish connection to database
   {
       try
       {
           DriverManager.registerDriver(new org.apache.derby.jdbc.ClientDriver()); // load Sun driver
           myConnection = DriverManager.getConnection(databaseURL); // connect to database
           myStatement = myConnection.createStatement(); // create statement for executing SQL
       }
       
       catch (SQLException ex)
       {
           ex.printStackTrace();
       }
       
       createUserInterface(); // set up GUI
   }
   
   private void createUserInterface() throws SQLException
   {
       Container contentPane = getContentPane(); // get content pane for attaching GUI components
       contentPane.setLayout(null); // enable explicit positioning of GUI components
       
       // --- Team Combo Box Set Up ---
       teamPanel = new JPanel(); // set up Team Panel
       teamPanel.setBounds(40, 20, 276, 48);
       teamPanel.setBorder(BorderFactory.createEtchedBorder());
       teamPanel.setLayout(null);
       teamPanel.setSize(400, 600); 
       contentPane.add(teamPanel);
       
       teamLabel = new JLabel(); // set up Team Label
       teamLabel.setBounds(25, 15, 100, 20);
       teamLabel.setText("Team: ");
       teamPanel.add(teamLabel);
       
       teamComboBox = new JComboBox(); // set up Team Panel
       teamComboBox.setBounds(150, 15, 96, 25);
       teamComboBox.addItem("");
       teamComboBox.setSelectedIndex(0);
       teamPanel.add(teamComboBox);
       
       // --- JSlider #1 ---      
        teamLabel = new JLabel();
        teamLabel.setBounds(25, 75, 100, 40);
        teamLabel.setText("Q1: Technicality ");
        teamPanel.add(teamLabel);
        
        final JSlider js1 = new JSlider(JSlider.HORIZONTAL, 1, 5, 1);
        js1.setBounds(125, 80, 200, 40);
        js1.setSnapToTicks(true);
        js1.setPaintTicks(true);
        js1.setPaintLabels(true);
        js1.setMajorTickSpacing(1);
        teamPanel.add(js1);
        
        // --- JSlider #2 ---      
        teamLabel = new JLabel();
        teamLabel.setBounds(25, 120, 100, 60);
        teamLabel.setText("Q2: Usefulness ");
        teamPanel.add(teamLabel);        
        
        final JSlider js2 = new JSlider(JSlider.HORIZONTAL, 1, 5, 1);
        js2.setBounds(125, 125, 200, 55);
        js2.setSnapToTicks(true);
        js2.setPaintTicks(true);
        js2.setPaintLabels(true);
        js2.setMajorTickSpacing(1);
        teamPanel.add(js2);
        
        // --- JSlider #3 ---    
        teamLabel = new JLabel();
        teamLabel.setBounds(25, 165, 100, 80);
        teamLabel.setText("Q3:  Clarity ");
        teamPanel.add(teamLabel);
        
        final JSlider js3 = new JSlider(JSlider.HORIZONTAL, 1, 5, 1);
        js3.setBounds(125, 170, 200, 70);
        js3.setSnapToTicks(true);
        js3.setPaintTicks(true);
        js3.setPaintLabels(true);
        js3.setMajorTickSpacing(1);
        teamPanel.add(js3);
        
        // --- JSlider #4 ---
        teamLabel = new JLabel();
        teamLabel.setBounds(25, 210, 100, 100);
        teamLabel.setText("Q4:  Overall ");
        teamPanel.add(teamLabel);
        
        final JSlider js4 = new JSlider(JSlider.HORIZONTAL, 1, 5, 1);
        js4.setBounds(125, 215, 200, 95);
        js4.setSnapToTicks(true);
        js4.setPaintTicks(true);
        js4.setPaintLabels(true);
        js4.setMajorTickSpacing(1);
        teamPanel.add(js4);
        
        // --- Comments Box ---
        Border b = new LineBorder(Color.GRAY, 2);
        final JTextArea commentBox = new JTextArea("", 5, 5);
        final JScrollPane commentScroll = new JScrollPane(commentBox, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_NEVER);
        commentScroll.setBorder(BorderFactory.createTitledBorder("Comments:"));
        commentBox.setFont(new Font("Serif", Font.LAYOUT_LEFT_TO_RIGHT, 14));        
        commentScroll.setBounds(40, 315, 310, 150);
        commentBox.setBorder(b);
        commentBox.setLineWrap(true);
        commentBox.setWrapStyleWord(true);
        teamPanel.add(commentScroll);

        // --- Average Result Text Field ---
        avgResultText = new JTextField("");
        avgResultText.setBounds(160, 480, 100, 25);
        teamPanel.add(avgResultText);
        
        // --- Calc Average ---
        final JButton calcAvgButton = new JButton("Calc Avg");
        calcAvgButton.setBounds(55, 480, 100, 25);
        teamPanel.add(calcAvgButton);
        
        calcAvgButton.addActionListener(new ActionListener() 
        {
            @Override
            public void actionPerformed(ActionEvent e) 
            {
                avg = ((js1.getValue() + js2.getValue() + js3.getValue() + js4.getValue()) / 4.0);
                String sAvg = String.valueOf(avg);
                avgResultText.setText(sAvg);
            }
        });

        // --- JButton Clear ---
        final JButton clearButton = new JButton("Clear");
        clearButton.setBounds(40, 530, 80, 55);
        teamPanel.add(clearButton);
        
        clearButton.addActionListener(new ActionListener() 
        {
            @Override
            public void actionPerformed(ActionEvent e) 
            {
                js1.setValue(1);
                js2.setValue(1);
                js3.setValue(1);
                js4.setValue(1);
                commentBox.setText(null);
                avgResultText.setText(null);
                teamComboBox.setSelectedItem("");     
            }
        });
        
        // --- JButton Submit ---
        submitButton = new JButton("Submit");
        submitButton.setBounds(260, 530, 80, 55);
        teamPanel.add(submitButton);
        submitButton.setEnabled(false);
        
        avgResultText.getDocument().addDocumentListener(new DocumentListener()
        {
            @Override
            public void changedUpdate(DocumentEvent e)
            {
                changed();
            }
            
            @Override
            public void removeUpdate(DocumentEvent e)
            {
                changed();
            }
            
            @Override
            public void insertUpdate(DocumentEvent e)
            {
                changed();
            }
        });
        
        submitButton.addActionListener(new ActionListener() 
        {
            @Override
            public void actionPerformed(ActionEvent e) 
            {
                try
                {
                    String sql = "UPDATE TEAMEVAL "
                    + "SET Q1 = ?, Q2 = ?, Q3 = ?, Q4 = ?, AVGSCORE = ?, COMMENTS = ?"
                    + "WHERE TEAMNAME =?";

                    PreparedStatement ps = myConnection.prepareStatement(sql);
                    ps.setInt(1, js1.getValue());
                    ps.setInt(2, js2.getValue());
                    ps.setInt(3, js3.getValue());
                    ps.setInt(4, js4.getValue());
                    ps.setString(5, avgResultText.getText());
                    ps.setString(6, commentBox.getText());
                    ps.setObject(7, teamComboBox.getSelectedItem());
                    ps.executeUpdate();
                }
                
                catch (SQLException ex)
                {
                    ex.printStackTrace();
                }  
            }          
        });
       
       setTitle("Evaluation");
       setSize(375, 410);
       setVisible(true);
       loadTeams();
   }
   
   public void changed()
   {
        if (avgResultText.getText().equals(""))
            submitButton.setEnabled(false);
        
        else
            submitButton.setEnabled(true);
   }
   
   private void loadTeams() throws SQLException // get all account numbers from database
   {
      try 
      {
         myResultSet = myStatement.executeQuery("select DISTINCT TEAMNAME from APP.TEAMEVAL");

         while (myResultSet.next()) // add account numbers to accountNumberJComboBox
             teamComboBox.addItem(myResultSet.getString("TEAMNAME"));

         myResultSet.close(); // close myResultSet
      } // end try

      catch (SQLException ex)
      {
         ex.printStackTrace();
      }
   } // end try
}