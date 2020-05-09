<?php
$host = "wnet.dev";
$dbusername = "chengod_chengod";
$dbpassword = "ikweetniks3";
$dbname = "chengod_ichef";

echo register("testPhp","test");

function login($username, $password) {
    try {
        $pdo = new PDO("mysql:host=wnet.dev;dbname=chengod_ichef", 'chengod_chengod', 'ikweetniks3');
 
        $sql = 'CALL Login(?,?)';
        $stmt = $pdo->prepare($sql);
		
		// pass value to the command
        $stmt->bindParam(1, $username, PDO::PARAM_STR|PDO::PARAM_INPUT_OUTPUT, 20);
        $stmt->bindParam(2, $password, PDO::PARAM_STR|PDO::PARAM_INPUT_OUTPUT, 20);
		
        $stmt->execute();
        do {
        $rows = $stmt->fetchAll(PDO::FETCH_NUM);
        if ($rows) {
            print_r($rows);
        }
        } while ($stmt->nextRowset());
    }   

    catch (PDOException $e) {
        die("Error occurred:" . $e->getMessage());
    }
}

function register($username, $password) {
    try {
        $pdo = new PDO("mysql:host=wnet.dev;dbname=chengod_ichef", 'chengod_chengod', 'ikweetniks3');
 
        $sql = 'CALL Register(?,?)';
        $stmt = $pdo->prepare($sql);
		
		// pass value to the command
        $stmt->bindParam(1, $username, PDO::PARAM_STR|PDO::PARAM_INPUT_OUTPUT, 20);
        $stmt->bindParam(2, $password, PDO::PARAM_STR|PDO::PARAM_INPUT_OUTPUT, 20);
		
        $stmt->execute();
        
        if ($arr = $stmt->errorInfo() == "00000")
        {
            echo "Account registered!";
        }
        else
        {   
            echo "\nPDOStatement::errorInfo():\n";
            $arr = $stmt->errorInfo();
            print_r($arr);	
        }        
    }   
    catch (PDOException $e) {
        die("Error occurred:" . $e->getMessage());
    }
}