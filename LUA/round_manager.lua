local RoundManager = {}
local PointsManager = require(game.ServerScriptService.Core:WaitForChild("PointsManager"))
local Players = game:GetService("Players")

function RoundManager:getKiller()
	local killers = game:GetService("ServerStorage"):WaitForChild("Killers"):GetChildren()
	local randomKiller = killers[math.random(1, #killers)]
	print("Chosen Killer: "..randomKiller.Name)
	return randomKiller
end

function RoundManager:spawnKiller()
	local chosenKiller = RoundManager:getKiller():Clone()
	chosenKiller.Parent = game:GetService("Workspace"):WaitForChild("currentKiller")
	print("Killer: "..chosenKiller.Name.." Spawned")
	return chosenKiller
end

function RoundManager:printSurvivors(player)
	local message = Instance.new("Message")
	message.Name = "message"
	message.Text = string.format("Survivors: %s", player.Name)
	message.Parent = game.Workspace
	wait(3)
	message:Destroy()
end

function RoundManager:awardPlayers()
	for i,v in pairs(Players:GetPlayers()) do
		if v.isDead.Value == false then
			PointsManager:addPoints(1, v)
			RoundManager:printSurvivors(v)
		end
		
	end
end

function RoundManager:roundTime(time_)
	local roundTime = time_
	for i = 1, roundTime, 1 do
		wait(1)
		print(i)
	end
	print("Round Ended ")
	wait()
end

function RoundManager:Init(time_, intermissionTime)
	
	local killer = RoundManager:spawnKiller()
	
	RoundManager:roundTime(time_)
	killer:Destroy()
	
	RoundManager:awardPlayers()
	
	for i,v in pairs(Players:GetPlayers()) do
		v.isDead.Value = false
	end
	
	print("Intermission Started")
	wait(intermissionTime)
	print("Intermission Ended")
	
end


return RoundManager