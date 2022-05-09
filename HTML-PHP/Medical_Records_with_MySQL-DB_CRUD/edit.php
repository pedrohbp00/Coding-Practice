<?php
	include("db.php");

	if(isset($_GET['id'])):
		$id = mysql_escape_string($_GET['id']);
		$sql = "SELECT * FROM paciente WHERE id = '$id'";
		$resultado = mysql_query($sql);
		$dados = mysql_fetch_array($resultado);
	endif;
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
		<center><h1>UniClinica | Alterar Prontuário do Paciente</h1>
		</center>
	</div>
	<center>
	<div class="panel">
		<form action="update.php" method="POST">
			<input type="hidden" name="id" value="<?php echo $dados['id']?>">
			<table width="50%">
				<tr>
					<td style="float: right;">Nome Completo:</td>
					<td><input type="text" name="nome" value="<?php echo $dados['nome']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">CPF:</td>
					<td><input type="text" class="form-control cpf-mask" name="cpf" value="<?php echo $dados['cpf']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">Telefone p/ Contato:</td>
					<td><input type="text" class="form-control phone-ddd-mask" name="telefone" value="<?php echo $dados['telefone']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">Queixa Principal:</td>
					<td><input type="text" name="queixa" value="<?php echo $dados['queixa']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">1-Sofre(u) de hemorragia:</td>
					<input type="hidden" name="q1" value="0"/>
					<td><input type="checkbox" name="q1" value="<?php echo $dados['q1']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">2-Sofre(u) de alergia:</td>
					<input type="hidden" name="q2" value="0"/>
					<td><input type="checkbox" name="q2" value="<?php echo $dados['q2']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">3-Sofre(u) de diabetes:</td>
					<input type="hidden" name="q3" value="0"/>
					<td><input type="checkbox" name="q3" value="<?php echo $dados['q3']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">4-Sofre(u) de distúrbio cardiovascular:</td>
					<input type="hidden" name="q4" value="0"/>
					<td><input type="checkbox" name="q4" value="<?php echo $dados['q4']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">5-Está tomando algum medicamento:</td>
					<input type="hidden" name="q5" value="0"/>
					<td><input type="checkbox" name="q5" value="<?php echo $dados['q5']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">6-Faz uso de entorpecentes:</td>
					<input type="hidden" name="q6" value="0"/>
					<td><input type="checkbox" name="q6" value="<?php echo $dados['q6']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">7-Tem ansiedade ou depressão:</td>
					<input type="hidden" name="q7" value="0"/>
					<td><input type="checkbox" name="q7" value="<?php echo $dados['q7']?>"></td>
				</tr>
				<tr>
					<td style="float: right;">8-Fuma com muita frequência:</td>
					<input type="hidden" name="q8" value="0"/>
					<td><input type="checkbox" name="q8" value="<?php echo $dados['q8']?>"></td>
				</tr>
			</table>
			<input type="submit" name="btn-editar" value="Atualizar Dados" style="width: 50%">
		</form>
	</div>
	</center>
</body>
</html>