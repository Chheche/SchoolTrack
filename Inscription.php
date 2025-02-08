<?php
function Inscription($nomP, $prenomP, $nomE, $prenomE, $num_tel, $mail, $niveau,$commentaire,$etat)
{
    $servername = "localhost";
    $username = "groupe3";
    $password = "TsoinTsoin321";
    $dbname = "groupe32";

    $conn = new mysqli($servername, $username, $password, $dbname);

    if ($conn->connect_error) {
        return '<p>La connexion à la base de données a échoué : ' . $conn->connect_error . '</p>';
    }
    $message="";

    $check_sql = "SELECT COUNT(*) as count FROM parent WHERE mail = ?";
    $check_stmt = $conn->prepare($check_sql);
    $check_stmt->bind_param("s", $mail);
    $check_stmt->execute();
    $result = $check_stmt->get_result();
    $row = $result->fetch_assoc();

    if ($row['count'] == 0) {
        $mdp = bin2hex(random_bytes(8));
        $mdp_hash = password_hash($mdp, PASSWORD_DEFAULT);

        $sqlParent = 'INSERT INTO parent (mail, nom, prenom, mdp, tel) VALUES (?, ?, ?, ?, ?)';
        $stmtParent = $conn->prepare($sqlParent);
        $stmtParent->bind_param("sssss", $mail, $nomP, $prenomP, $mdp_hash, $num_tel);

        if ($stmtParent->execute()) {
            $message = "<p>Inscription envoyée. Attention, retenez ce mot de passe : $mdp.</p>";
        } else {
            $message .= '<p>Erreur lors de l\'insertion des données : ' . $conn->error . '</p>';
        }
        $stmtParent->close();
    }

    $dateDuJour = date("Y-m-d");


    $sql_dossier = 'INSERT INTO dossier (mail_parent,nom,prenom,niveau,date,commentaire,etat) VALUES (?,?,?,?,?,?,?)';
    $stmtDossier = $conn->prepare($sql_dossier);
    $stmtDossier->bind_param("sssissi", $mail, $nomE, $prenomE, $niveau, $dateDuJour,$commentaire,$etat);

    if ($stmtDossier->execute()) {
        $message .= "<p>Dossier enregistré</p>";
    } else {
        $message .= '<p>Erreur lors de l\'insertion des données : ' . $conn->error . '</p>';
    }

    $conn->close();
    return $message ;
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nomP = $_POST["nomP"];
    $prenomP = $_POST["prenomP"];
    $nomE = $_POST["nomE"];
    $prenomE = $_POST["prenomE"];
    $num_tel = $_POST["telephone"];
    $mail = $_POST["email"];
    $niveau = $_POST["niveau"];
    $commentaire =$_POST["commentaire"];
    $etat=0;
    echo Inscription($nomP, $prenomP, $nomE, $prenomE, $num_tel, $mail, $niveau,$commentaire,$etat);
}
?>
<body>
    <h1>Inscription à l'école</h1>
    <form  method="post">
        <h1>Information Parent </h1>
        <label for="nom">Nom Parent :</label>
        <input type="text" id="nomP" name="nomP" required><br><br>

        <label for="prenom">Prénom Parent :</label>
        <input type="text" id="prenomP" name="prenomP" required><br><br>


        <label for="email">Email Parent:</label>
        <input type="email" id="email" name="email" required><br><br>

        <label for="telephone">Téléphone Parent :</label>
        <input type="tel" id="telephone" name="telephone" required><br><br>

        <h1>Information Enfant</h1>
        <label for="nom">Nom Enfant :</label>
        <input type="text" id="nomE" name="nomE" required><br><br>

        <label for="prenom">Prénom Enfant :</label>
        <input type="text" id="prenomE" name="prenomE" required><br><br>

        <label for="niveau">Niveau Scolaire :</label>
        <select id="niveau" name="niveau" required>
            <option value="0">6e</option>
            <option value="1">5e</option>
            <option value="2">4e</option>
            <option value="3">3e</option>
            <option value="4">Seconde</option>
            <option value="5">Première</option>
            <option value="6">Terminale</option>
        </select><br><br>

        <label for="commentaire">Commentaire :</label>
        <textarea id="commentaire" name="commentaire" rows="4" cols="50" required></textarea><br><br>


        <input type="submit" value="Soumettre">
    </form>
</body>
</html>