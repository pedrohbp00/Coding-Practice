local PointsManager = {}

function PointsManager:createStats(player)
	print("Creating Stats Leaderboard")
	local leaderstats = Instance.new("Folder", player)
	leaderstats.Name = "leaderstats"
	local points = Instance.new("IntValue", leaderstats)
	points.Name = "Points"
	points.Value = 0
	print("Stats Leaderboard Successfully Created")
	
	local isDead = Instance.new("BoolValue", player)
	isDead.Name = "isDead"
	isDead.Value = false
end

function PointsManager:removePoints(removeValue, player)
	player.leaderstats.Points.Value -= removeValue
	print("Removed "..removeValue.." points from player: "..player.Name)
end

function PointsManager:addPoints(addValue, player)
	player.leaderstats.Points.Value = player.leaderstats.Points.Value + addValue
	print("Added "..addValue.." points to player: "..player.Name)
end

function PointsManager:Init()
	game.Players.PlayerAdded:Connect(function(plr)
		PointsManager:createStats(plr)
		
		plr.CharacterAdded:Connect(function(character)
			character:WaitForChild("Humanoid").Died:Connect(function()
				plr.isDead.Value = true
				print(plr.Name.." died")
			end)
		end)
		
	end)
end

return PointsManager
