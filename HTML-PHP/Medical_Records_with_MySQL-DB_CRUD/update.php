<?php
	include("db.php");

	if(isset($_POST['btn-editar'])):
		
		$nome = mysql_escape_string($_POST['nome']);
		$cpf = mysql_escape_string($_POST['cpf']);
		$telefone = mysql_escape_string($_POST['telefone']);
		$queixa = mysql_escape_string($_POST['queixa']);
		$q1 = $_POST['q1'];
		$q2 = $_POST['q2'];
		$q3 = $_POST['q3'];
		$q4 = $_POST['q4'];
		$q5 = $_POST['q5'];
		$q6 = $_POST['q6'];
		$q7 = $_POST['q7'];
		$q8 = $_POST['q8'];

		$id = mysql_escape_string($_POST['id']);

		$sql = "UPDATE paciente SET nome = '$nome', cpf = '$cpf', telefone = '$telefone', queixa = '$queixa', q1 = '$q1', q2 = '$q2', q3 = '$q3', q4 = '$q4', q5 = '$q5', q6 = '$q6', q7 = '$q7', q8 = '$q8' WHERE id = '$id' ";

		mysql_query($sql);

		header('Location: busca.php');

	endif;

?>
