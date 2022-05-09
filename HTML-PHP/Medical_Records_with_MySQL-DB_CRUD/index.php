<?php
	include("db.php");
	$error = "";
	if(isset($_POST['registrar'])){
		$nome = $_POST['nome'];
		$cpf = $_POST['cpf'];
		$telefone = $_POST['telefone'];
		$queixa = $_POST['queixa'];
		$q1 = $_POST['q1'];
		$q2 = $_POST['q2'];
		$q3 = $_POST['q3'];
		$q4 = $_POST['q4'];
		$q5 = $_POST['q5'];
		$q6 = $_POST['q6'];
		$q7 = $_POST['q7'];
		$q8 = $_POST['q8'];

		$verifyCPF = mysql_query("SELECT * FROM paciente WHERE cpf = '$cpf'");
		$verifyTEL = mysql_query("SELECT * FROM paciente WHERE telefone = '$telefone'");

		if(strlen($nome) < 2){
			$error = "<h2 style='color:red'>Nome muito pequeno!</h2>";
		}else if (strlen($cpf) < 11) {
			$error = "<h2 style='color:red'>CPF inválido!</h2>";
		}else if(mysql_num_rows($verifyCPF) > 0){
			$error = "<h2 style='color:red'>CPF já registrado!</h2>";
		}else if(mysql_num_rows($verifyTEL) > 0){
			$error = "<h2 style='color:red'>Telefone já registrado!</h2>";
		}else{
			mysql_query("INSERT INTO paciente (nome, cpf, telefone, queixa, q1, q2, q3, q4, q5, q6, q7, q8) VALUES ('$nome', '$cpf', '$telefone', '$queixa', '$q1', '$q2', '$q3', '$q4', '$q5', '$q6', '$q7', '$q8')");

			$error = "<h2 style='color:green'>Paciente registrado com sucesso!</h2>";
		}
	}
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>UniClinica</title>
	<link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
	<?php include("header.php")?>
	<div class="panel">
		<center><h1>UniClinica | Cadastro de Paciente - Prontuário</h1>
		</center>
	</div>
	<center>
	<div class="panel">
		<?php echo $error; ?>
		<form method="POST">
			<table width="50%">
				<tr>
					<td style="float: right;">Nome Completo:</td>
					<td><input type="text" name="nome" placeholder="Nome"></td>
				</tr>
				<tr>
					<td style="float: right;">CPF:</td>
					<td><input type="text" class="form-control cpf-mask" name="cpf" placeholder="Ex.: 000.000.000-00"></td>
				</tr>
				<tr>
					<td style="float: right;">Telefone p/ Contato:</td>
					<td><input type="text" class="form-control phone-ddd-mask" name="telefone" placeholder="Ex.: (00) 0000-0000"></td>
				</tr>
				<tr>
					<td style="float: right;">Queixa Principal:</td>
					<td><input type="text" name="queixa" placeholder="Queixa Principal"></td>
				</tr>
				<tr>
					<td style="float: right;">1-Sofre(u) de hemorragia:</td>
					<input type="hidden" name="q1" value="0"/>
					<td><input type="checkbox" name="q1" value="1"></td>
				</tr>
				<tr>
					<td style="float: right;">2-Sofre(u) de alergia:</td>
					<input type="hidden" name="q2" value="0"/>
					<td><input type="checkbox" name="q2" value="1"></td>
				</tr>
				<tr>
					<td style="float: right;">3-Sofre(u) de diabetes:</td>
					<input type="hidden" name="q3" value="0"/>
					<td><input type="checkbox" name="q3" value="1"></td>
				</tr>
				<tr>
					<td style="float: right;">4-Sofre(u) de distúrbio cardiovascular:</td>
					<input type="hidden" name="q4" value="0"/>
					<td><input type="checkbox" name="q4" value="1"></td>
				</tr>
				<tr>
					<td style="float: right;">5-Está tomando algum medicamento:</td>
					<input type="hidden" name="q5" value="0"/>
					<td><input type="checkbox" name="q5" value="1"></td>
				</tr>
				<tr>
					<td style="float: right;">6-Faz uso de entorpecentes:</td>
					<input type="hidden" name="q6" value="0"/>
					<td><input type="checkbox" name="q6" value="1"></td>
				</tr>
				<tr>
					<td style="float: right;">7-Tem ansiedade ou depressão:</td>
					<input type="hidden" name="q7" value="0"/>
					<td><input type="checkbox" name="q7" value="1"></td>
				</tr>
				<tr>
					<td style="float: right;">8-Fuma com muita frequência:</td>
					<input type="hidden" name="q8" value="0"/>
					<td><input type="checkbox" name="q8" value="1"></td>
				</tr>
			</table>
			<input type="submit" name="registrar" value="Cadastrar Paciente" style="width: 50%">
		</form>
	</div>
	</center>
</body>
</html>