<?php
include("db.php");

//if(isset($_POST['btn-deletar'])):
		$id = mysql_escape_string($_GET['id']);

		$sql = "DELETE FROM paciente WHERE id = '$id'";

		mysql_query($sql);

		header('Location: busca.php');
//endif;
?>