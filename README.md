# DistributedTicTacToe\

  #The project will contain three parts:Client, Front end and Server  
  #The bully argorithm will be used to elect a leader among replication managers (Servers)

  Client  
    - Will be written i C#  
  
  Front end  
    - Will be written i C++  
  
  Server  
    - Will be written i C++  
    - The server will use passive replication  

  Message flow:
    1. Messages will be sent from a client to the front end  
    2. The front end will send the message to the active replica manager (server)  
    3. The replication manager handles the message  
    4. The replication manager sends replies to the clients involved  

  #Potential features:  
    - Statistics and match results/current state in a sqllite database  
