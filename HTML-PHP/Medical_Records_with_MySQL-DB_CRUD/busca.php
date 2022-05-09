<?php include("db.php")?>

<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" type="text/css" href="style.css">
	<?php include("header.php")?>
</head>
<body>
	<center>
		<div class="panel">
		<h1><center>UniClinica | Pacientes</center></h1>
		<table class="striped">
			<thead>
				<tr>
					<br>
					<br>
					<th>Nome Completo---------------------</th>
					<th>CPF---------------------</th>
					<th>Telefone---------------------</th>
					<th>Queixa Principal---------------------</th>
				</tr>
			</thead>

			<tbody>
				<?php
					$sql = "SELECT * FROM paciente";
					$resultado = mysql_query($sql);
					while ($dados = mysql_fetch_array($resultado)):
				?>
				<tr>
					<td><?php echo $dados['nome']; ?></td>
					<td><?php echo $dados['cpf']; ?></td>
					<td><?php echo $dados['telefone']; ?></td>
					<td><?php echo $dados['queixa']; ?></td>
					<td><a href="edit.php?id=<?php echo $dados['id'];?>" class="btn">Editar</a></td>
					<td><a href="delete.php?id=<?php echo $dados['id'];?>" name="btn-deletar" class="btn">Remover</a></td>


				</tr>
				<?php endwhile; ?>
			</tbody>

		</table>
		<br>
		<a href="index.php" class="btn" >Adicionar Paciente</a>
	</div>
	</center>
</body>
</html>
